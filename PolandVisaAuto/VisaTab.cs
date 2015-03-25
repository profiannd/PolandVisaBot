using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using pvhelper;

namespace PolandVisaAuto
{
    public class VisaTab
    {
        private WebBrowser webBrowser;
        private RichTextBox richText;
        private Button deleteTask;
        private Button renewTask;
        private bool _allowStep = true;
        private RotEvents _enum = RotEvents.Start;
        private VisaTask _currentTask = null;
        public List<VisaTask> Tasks = new List<VisaTask>();
        public bool IsTabExists { get; set; }
        private TabPage _tabPage;
        private VisaComparer vc = new VisaComparer();
        public delegate void TaskDelegate(VisaTask task);
        public event TaskDelegate TaskEvent;

        public delegate void TabDelegate(TabPage tab);
        public event TabDelegate TabEvent;

        public delegate void TabDelegateMain(VisaTab visa, bool add);
        public event TabDelegateMain VisaEvent;

        public delegate void TabDelegateEx(TabPage tab, bool alarm);
        public event TabDelegateEx TabEventEx;

        private SoundPlayer sp;
        private bool _playSound = false;

        private void initSound()
        {
            Assembly assembly;
            assembly = Assembly.GetExecutingAssembly();
            sp = new SoundPlayer(assembly.GetManifestResourceStream("PolandVisaAuto.WindowsError.wav"));
        }

        public VisaTab(){}
        public VisaTab(VisaTask task, TabPage tabPage)
        {
            initSound();
            Tasks.Add(task);
            _tabPage = tabPage;

            richText = (RichTextBox)_tabPage.Controls.Find("richText", true)[0];
            webBrowser = (WebBrowser)_tabPage.Controls.Find("webBrowser" + task.City, true)[0];
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);
            
            renewTask = (Button) _tabPage.Controls.Find("renewTask", true)[0];
            renewTask.Click += new System.EventHandler(this.renewTask_click);

            deleteTask = (Button)_tabPage.Controls.Find("deleteTask", true)[0];
            deleteTask.Click += new System.EventHandler(this.deleteTask_click);

        }

        private void deleteTask_click(object sender, EventArgs e)
        {
            if (VisaEvent != null)
                VisaEvent(this, false);

            Tasks.Remove(_currentTask);
            if (TaskEvent != null)
            {
                TaskEvent(_currentTask);
                _currentTask = null;
            }
            _enum = RotEvents.Start;

            if (Tasks.Count == 0 && TabEvent != null)
            {
                TabEvent(_tabPage);
            }

            _allowStep = true;
        }

        private void renewTask_click(object sender, EventArgs e)
        {
            TurnAlarmOn(false);
            if (VisaEvent != null)
                VisaEvent(this, false);
            _currentTask = null;
            _enum = RotEvents.Start;
            _allowStep = true;
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            _allowStep = true;
        }


        public void DoStep()
        {
            if (_playSound)
                playSound();

            if(!_allowStep)
                return;
            _allowStep = false;

            try
            {
                switch (_enum)
                {
                    case RotEvents.Start:
                        {
                            Tasks.Sort(vc);
                            _currentTask = Tasks[0];
                            webBrowser.Navigate(Const.url);
                            _enum = RotEvents.Firsthl;
                            break;
                        }
                    case RotEvents.Firsthl:
                        {
                            pressOnLink(webBrowser, "Призначити дату подачі документів");
                            //webBrowser.Document.GetElementsByTagName("a")[0].InvokeMember("click");
                            _enum = RotEvents.FirstCombo;
                            break;
                        }
                    case RotEvents.FirstCombo:
                        {
                            webBrowser.Document.GetElementById("ctl00_plhMain_cboVAC").SetAttribute("selectedIndex", _currentTask.CityCode);
                            webBrowser.Document.GetElementById("ctl00_plhMain_cboPurpose").SetAttribute("selectedIndex", _currentTask.PurposeCode);
                            webBrowser.Document.GetElementById("ctl00_plhMain_btnSubmit").InvokeMember("click");
                            _enum = RotEvents.SecondCombo;
                            break;
                        }
                    case RotEvents.SecondCombo:
                        {
                            webBrowser.Document.GetElementById("ctl00_plhMain_tbxNumOfApplicants").SetAttribute("value", _currentTask.CountAdult.ToString());
                            if (webBrowser.Document.GetElementById("ctl00_plhMain_txtChildren") != null)
                                webBrowser.Document.GetElementById("ctl00_plhMain_txtChildren").SetAttribute("value", _currentTask.CountChild.ToString());

                            for (int i = 0; i < this.webBrowser.Document.GetElementById("ctl00_plhMain_cboVisaCategory").Children.Count; i++)
                            {
                                HtmlElement child = this.webBrowser.Document.GetElementById("ctl00_plhMain_cboVisaCategory").Children[i];
                                if (child.InnerText == _currentTask.Category)
                                {
                                    this.webBrowser.Document.GetElementById("ctl00_plhMain_cboVisaCategory").SetAttribute("selectedIndex", i.ToString());
                                    break;
                                }
                            }
                            this.webBrowser.Document.GetElementById("ctl00_plhMain_cboVisaCategory").InvokeMember("onchange");
                            _enum = RotEvents.Submit;
                            break;
                        }
                    case RotEvents.Submit:
                        {
                            string showStopper = webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg").InnerText;
                            if (showStopper.Contains("Number of Persons should not be"))
                            {
                                Logger.Warning("Сбой в работе сайта. Ошибка: " + showStopper);
                                _currentTask = null;
                                _enum = RotEvents.Start;
                                _allowStep = true;
                                break;
                            }
                            richText.Text = "Свободна дата: " + showStopper;
                            Logger.Info(_currentTask.City + ": "+ richText.Text);
                            if (!showStopper.Contains("No date(s) available"))
                            {
                                var apointmentDate = ProcessDate(showStopper);
                                if (apointmentDate < _currentTask.RedLineDt)
                                {
                                    webBrowser.Document.GetElementById("ctl00_plhMain_btnSubmit").InvokeMember("click");
                                    _enum = RotEvents.FillReceipt;
                                    TurnAlarmOn(true);
                                    if (VisaEvent != null)
                                        VisaEvent(this, true);
                                    break;
                                }
                                else
                                {
                                    foreach (VisaTask visaTask in Tasks)
                                    {
                                        if (apointmentDate < visaTask.RedLineDt)
                                            _currentTask = visaTask;
                                    }
                                }
                            }
                            webBrowser.Document.GetElementById("ctl00_plhMain_btnCancel").InvokeMember("click");
                            _enum = RotEvents.FirstCombo;
                            break;
                        }
                    case RotEvents.FillReceipt:
                        {
                            Logger.Info(_currentTask.City+": Номер квитанции: " + _currentTask.Receipt);
                            webBrowser.Document.GetElementById("ctl00_plhMain_repAppReceiptDetails_ctl01_txtReceiptNumber").SetAttribute("value", _currentTask.Receipt);
                            webBrowser.Document.GetElementById("ctl00_plhMain_btnSubmit").InvokeMember("click");
                            _enum = RotEvents.FillEmail;
                            break;
                        }
                    case RotEvents.FillEmail:
                        {
                            if (webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg") != null && !string.IsNullOrEmpty(webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg").InnerHtml))
                            {
                                string text = webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg").InnerText;
                                Logger.Error("Надо исправить ошибку: \r\n " + text);
                                richText.Text = "Надо исправить ошибку: \r\n " + text;
                                renewTask.Visible = true;
                                deleteTask.Visible = true;
                                _enum = RotEvents.FillReceipt;
                                break;
                            }
                            Logger.Info(string.Format("{0}: Email: {1} Pass: {2}", _currentTask.City,_currentTask.Email, _currentTask.Password));
                            webBrowser.Document.GetElementById("ctl00_plhMain_txtEmailID").SetAttribute("value", _currentTask.Email);
                            webBrowser.Document.GetElementById("ctl00_plhMain_txtPassword").SetAttribute("value", _currentTask.Password);
                            webBrowser.Document.GetElementById("ctl00_plhMain_btnSubmitDetails").InvokeMember("click");
                            _enum = RotEvents.GetData;
                            break;
                        }
                    case RotEvents.GetData:
                        {
                            if (webBrowser.Document.GetElementById("ctl00_plhMain_VS") != null && !string.IsNullOrEmpty(webBrowser.Document.GetElementById("ctl00_plhMain_VS").InnerText))
                            {
                                string error = webBrowser.Document.GetElementById("ctl00_plhMain_VS").InnerText;
                                Logger.Error("Надо исправить ошибку: \r\n " + error);
                                richText.Text ="Надо исправить ошибку: \r\n " + error;
                                renewTask.Visible = true;
                                deleteTask.Visible = true;
                                _enum = RotEvents.FillEmail;
                                break;
                            }
                            Logger.Warning("Дружищще, отправляй меня быстрее "+ _currentTask.GetInfo());
                            richText.AppendText(_currentTask.GetInfo());
                            webBrowser.Document.GetElementById("ctl00_plhMain_repAppVisaDetails_ctl01_tbxPPTEXPDT").SetAttribute("value", _currentTask.PassportEndDate);
                            webBrowser.Document.GetElementById("ctl00_plhMain_repAppVisaDetails_ctl01_cboTitle").SetAttribute("selectedIndex", _currentTask.StatusCode);
                            webBrowser.Document.GetElementById("ctl00_plhMain_repAppVisaDetails_ctl01_tbxFName").SetAttribute("value", _currentTask.Name);
                            webBrowser.Document.GetElementById("ctl00_plhMain_repAppVisaDetails_ctl01_tbxLName").SetAttribute("value", _currentTask.LastName);
                            webBrowser.Document.GetElementById("ctl00_plhMain_repAppVisaDetails_ctl01_tbxDOB").SetAttribute("value", _currentTask.Dob);
                            webBrowser.Document.GetElementById("ctl00_plhMain_repAppVisaDetails_ctl01_tbxReturn").SetAttribute("value", _currentTask.ArrivalDt);

                            for (int i = 0; i < this.webBrowser.Document.GetElementById("ctl00_plhMain_repAppVisaDetails_ctl01_cboNationality").Children.Count; i++)
                            {
                                HtmlElement child = this.webBrowser.Document.GetElementById("ctl00_plhMain_repAppVisaDetails_ctl01_cboNationality").Children[i];
                                if (child.InnerText == _currentTask.Nationality)
                                {
                                    this.webBrowser.Document.GetElementById("ctl00_plhMain_repAppVisaDetails_ctl01_cboNationality").SetAttribute("selectedIndex", i.ToString());
                                    break;
                                }
                            }

                            _enum = RotEvents.Stop;
                            break;
                        }
                    case RotEvents.Stop:
                        {
                            TurnAlarmOn(false);
                            renewTask.Visible = true;
                            deleteTask.Visible = true;
                            break;
                        }
                    //case RotEvents.StopPicture1://ctl00_plhMain_VS, ctl00_plhMain_lblMsg
                    //    {
                    //        string error1 = string.Empty;
                    //        string error2 = string.Empty;
                    //        if (webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg") != null)
                    //        {
                    //            error1 = webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg").InnerText;
                    //        }
                    //        if (webBrowser.Document.GetElementById("ctl00_plhMain_VS") != null)
                    //        {
                    //            error2 = webBrowser.Document.GetElementById("ctl00_plhMain_VS").InnerText;
                    //        }
                    //        if (!string.IsNullOrEmpty(error1) || !string.IsNullOrEmpty(error2))
                    //        {
                    //            Logger.Info(_currentTask.City + " ошибка. первая картинка. 1: "+ error1 +" 2: "+ error2);
                    //            _enum = RotEvents.StopPicture1;
                    //            break;
                    //        }
                    //        Logger.Info(_currentTask.City + " подтверждение первой картинки.");
                    //        _enum = RotEvents.StopPicture2;

                    //        break;
                    //    }
                    //case RotEvents.StopPicture2://ctl00_plhMain_lblMsg
                    //    {
                    //        string error1 = string.Empty;
                    //        if (webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg") != null)
                    //        {
                    //            error1 = webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg").InnerText;
                    //        }
                    //        if (!string.IsNullOrEmpty(error1))
                    //        {
                    //            Logger.Info(_currentTask.City + " ошибка. вторая картинка.  " + error1);
                    //            _enum = RotEvents.StopPicture2;
                    //            break;
                    //        }
                    //        Logger.Info(_currentTask.City + " подтверждение второй картинки.");
                    //        _enum = RotEvents.StopPicture3;

                    //        break;
                    //    }
                    //case RotEvents.StopPicture3://ctl00_plhMain_lblMsg
                    //    {
                    //        string error1 = string.Empty;
                    //        if (webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg") != null)
                    //        {
                    //            error1 = webBrowser.Document.GetElementById("ctl00_plhMain_lblMsg").InnerText;
                    //        }
                    //        if (!string.IsNullOrEmpty(error1))
                    //        {
                    //            Logger.Info(_currentTask.City + " ошибка. третья картинка.  " + error1);
                    //            _enum = RotEvents.StopPicture2;
                    //            break;
                    //        }
                    //        Logger.Info(_currentTask.City + " ну, все, отправил. ищем следующего.");

                    //        TurnAlarmOn(false);
                    //        Tasks.Remove(_currentTask);
                    //        if (TaskEvent != null)
                    //        {
                    //            TaskEvent(_currentTask);
                    //            _currentTask = null;
                    //        }
                    //        _enum = RotEvents.Start;

                    //        if (Tasks.Count == 0 && TabEvent != null)
                    //        {
                    //            TabEvent(_tabPage);
                    //        }
                    //        break;
                    //    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                TurnAlarmOn(false);
                if (VisaEvent != null)
                    VisaEvent(this, false);
                _allowStep = true;
                _enum = RotEvents.Start;
            }
        }

        public void CheckOnDeleteTask(VisaTask visaTask)
        {
            Tasks.Remove(visaTask);
            if (Tasks.Count == 0 && TabEvent != null)
            {
                TabEvent(_tabPage);
            }
            _enum = RotEvents.Start;
            _allowStep = true;
            TurnAlarmOn(false);
        }

        private void TurnAlarmOn(bool on)
        {
            _playSound = on;
            if (TabEventEx != null)
                TabEventEx(_tabPage, on);
        }

        private void playSound()
        {
            sp.Play();
        }

        private DateTime ProcessDate(string xnya)
        {
            DateTime dt = DateTime.MinValue;
            try
            {
                string[] splitted = xnya.Replace("Найближча доступна дата для реєстрації є ", "").Split('.');
                string s = string.Format("{0}/{1}/{2}", splitted[0], Const.GetMonthAsInt(splitted[1]), splitted[2]);
                dt = DateTime.ParseExact(s, Const.DateFormat, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return dt;
        }

        private void pressOnLink(WebBrowser webBrowser, string text)
        {
            try
            {
                var link = webBrowser.Document.GetElementsByTagName("a")[0];
                if (link.InnerText == text)
                    link.InvokeMember("click");
            }
            catch
            {
                foreach (HtmlElement link in webBrowser.Document.GetElementsByTagName("a"))
                {
                    if (link.InnerText == text)
                        link.InvokeMember("click");
                }
            }
        }
    }
}
