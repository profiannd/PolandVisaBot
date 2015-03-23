﻿using System;
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
        private bool _allowStep = true;
        private RotEvents _enum = RotEvents.Start;
        private VisaTask _currentTask = null;
        public List<VisaTask> Tasks = new List<VisaTask>();
        public bool IsTabExists { get; set; }
        private TabPage _tabPage;

        public delegate void TaskDelegate(VisaTask task);
        public event TaskDelegate TaskEvent;

        public delegate void TabDelegate(TabPage tab);
        public event TabDelegate TabEvent;

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
                            Tasks.Sort(new VisaComparer());
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
                            richText.Text = "Свободна дата: " + showStopper;
                            if (!showStopper.Contains("No date(s) available"))
                            {
                                var apointmentDate = ProcessDate(showStopper);
                                if (apointmentDate < _currentTask.RedLineDt)
                                {
                                    webBrowser.Document.GetElementById("ctl00_plhMain_btnSubmit").InvokeMember("click");
                                    _enum = RotEvents.FillReceipt;
                                    TurnAlarmOn(true);
                                    break;
                                }
                            }
                            webBrowser.Document.GetElementById("ctl00_plhMain_btnCancel").InvokeMember("click");
                            _enum = RotEvents.FirstCombo;
                            break;
                        }
                    case RotEvents.FillReceipt:
                        {
                            webBrowser.Document.GetElementById("ctl00_plhMain_repAppReceiptDetails_ctl01_txtReceiptNumber").SetAttribute("value", _currentTask.Receipt);
                            webBrowser.Document.GetElementById("ctl00_plhMain_btnSubmit").InvokeMember("click");
                            _enum = RotEvents.FillEmail;
                            break;
                        }
                    case RotEvents.FillEmail:
                        {
                            webBrowser.Document.GetElementById("ctl00_plhMain_txtEmailID").SetAttribute("value", _currentTask.Email);
                            webBrowser.Document.GetElementById("ctl00_plhMain_txtPassword").SetAttribute("value", _currentTask.Password);
                            webBrowser.Document.GetElementById("ctl00_plhMain_btnSubmitDetails").InvokeMember("click");
                            _enum = RotEvents.GetData;
                            break;
                        }
                    case RotEvents.GetData:
                        {
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
//                            Tasks.Remove(_currentTask);
//                            if (TaskEvent != null)
//                            {
//                                TaskEvent(_currentTask);
//                                _currentTask = null;
//                            }
//                            _enum = RotEvents.Start;
//
//                            if (Tasks.Count == 0 && TabEvent != null)
//                            {
//                                TabEvent(_tabPage);
//                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                TurnAlarmOn(false);
                _allowStep = true;
                _enum = RotEvents.Start;
                Debug.Write(ex.ToString());
            }
        }

        public void CheckOnDeleteTask(VisaTask visaTask)
        {
            Tasks.Remove(visaTask);
            if (Tasks.Count == 0 && TabEvent != null)
            {
                TabEvent(_tabPage);
            }
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
