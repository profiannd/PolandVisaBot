using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using pvhelper;
using Excel = Microsoft.Office.Interop.Excel;
using Timer = System.Windows.Forms.Timer;

namespace PolandVisaAuto
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FLASHWINFO
    {
        public UInt32 cbSize;
        public IntPtr hwnd;
        public UInt32 dwFlags;
        public UInt32 uCount;
        public UInt32 dwTimeout;
    }

    public partial class PVAutoFill : Form
    {
        private const string COMM = "Comm";
        private string _commFolder = string.Empty;
        private string _parentFolder = string.Empty;
        public const string DateFormat = "dd/MM/yyyy";
        private BindingList<VisaTask> _visaTasks;
        private BindingList<VisaTask> _completedVisaTasks;
        private string _cityBefore = string.Empty;
        private Engine _engine;
        private Dictionary<string, BindingList<VisaTask>> _cityTasks = new Dictionary<string, BindingList<VisaTask>>();
        private bool _isMain = true;
        Timer _timer;

        public PVAutoFill()
        {
            InitializeComponent();
        }

        public PVAutoFill(bool isMain, string city)
        {
            InitializeComponent();
            _isMain = isMain;
            this.Text = string.Format("{0} {1} ", city, this.Text);
        }

        private void btnaddTask_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
            txtPass.Focus();
            txtEmail.Focus();
            if (!VisaTask.IsValidEmailAddress(txtEmail.Text))
                return;

            if (!VisaTask.IsValidPassword(txtPass.Text))
                return;
            
            VisaTask task = new VisaTask()
                {
                    ArrivalDt = dtArrivalDate.Text,
                    Receipt = txtBillNum.Text,
                    Category = cbxCategory.SelectedItem.ToString(),
                    CategoryCode = Const.CategoryCodeByCat(cbxCategory.SelectedItem.ToString()),
                    City = cbxCity.SelectedItem.ToString(),
                    CityCode = Const.CityCodeByCity(cbxCity.SelectedItem.ToString()),
                    CountAdult = (int) numCountA.Value,
                    CountChild = (int) numCountC.Value,
                    Dob = dtDob.Text,
                    Email = txtEmail.Text,
                    LastName = txtLastName.Text,
                    Name = txtName.Text,
                    Nationality = cbxNation.SelectedItem.ToString(),
                    PassportEndDate = dtEndPass.Text,
                    Password = txtPass.Text,
                    Purpose = cbxPurpose.SelectedItem.ToString(),
                    PurposeCode = Const.PurposeCodeByPurpose(cbxPurpose.SelectedItem.ToString()),
                    Status = cbxStatus.SelectedItem.ToString(),
                    StatusCode = Const.StatusCodeByStatus(cbxStatus.SelectedItem.ToString()),
                    RedLine = dtRedLine.Text,
                    GreenLine = dtGreenLine.Text,
                    Priority = cbxPriority.SelectedIndex
                };

            Logger.Info("Задание добавленно " + task.GetInfo());
            _visaTasks.Add(task);
            VisaTask.Save(_visaTasks, VisaEntityType.New);
            dataGridView1.Refresh();
            SendMessage(task, Actions.Create);

            _engine.RefreshViewTabs();

            txtPass.Text = txtName.Text = txtBillNum.Text = txtEmail.Text = txtLastName.Text = txtName.Text = string.Empty;
        }

        private void SendMessage(VisaTask task, Actions action)
        {
            if (action == Actions.Create || action == Actions.Restore)
            {
                if (!CheckOnProcessExists(task.City))
                {
                    string newDir = Path.Combine(AssemblyDirectory, task.City);
                    if (!Directory.Exists(newDir))
                    {
                        Directory.CreateDirectory(newDir);
                        Directory.CreateDirectory(Path.Combine(newDir, COMM));
                    }
                    startProcess(task.City, newDir, new BindingList<VisaTask>() { task });
                }
            }
            Message mess = new Message()
                {
                    Action = action,
                    Task = task
                };
            Message.Serialize(mess, FilePath(task.City, task.Receipt.Replace("/","_")));
        }

        private string FilePath(string city, string receipt)
        {
            if (_isMain)
            {
                return Path.Combine(Path.Combine(Path.Combine(Environment.CurrentDirectory, city), COMM), receipt + ".xml");
            }
            else
            {
                string dir = Path.Combine(Environment.CurrentDirectory, COMM);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return Path.Combine(dir, receipt + ".xml");
            }
        }

        private void CreateMainCityInfo()
        {
            foreach (VisaTask vt in _visaTasks)
            {
                bool existsName = false;
                if (!_cityTasks.ContainsKey(vt.City))
                {
                    _cityTasks.Add(vt.City, new BindingList<VisaTask>() { vt });
                }
                else
                {
                    foreach (VisaTask visaTask in _cityTasks[vt.City])
                    {
                        if (visaTask.Password == vt.Password)
                        {
                            existsName = true;
                            break;
                        }
                    }
                    if (!existsName)
                        _cityTasks[vt.City].Add(vt);
                }
            }

            foreach (KeyValuePair<string, BindingList<VisaTask>> cityTask in _cityTasks)
            {
                try
                {
                    string newDir = Path.Combine(AssemblyDirectory, cityTask.Key);
                    startProcess(cityTask.Key, newDir, cityTask.Value);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                }
            }

        }

        private void startProcess(string city, string newDir, BindingList<VisaTask> tasks)
        {
            if (!Directory.Exists(newDir))
                Directory.CreateDirectory(newDir);
            File.Copy(Path.Combine(AssemblyDirectory, "PolandVisaAuto.exe"), Path.Combine(newDir, "PolandVisaAuto.exe"), true);
            File.Copy(Path.Combine(AssemblyDirectory, "PolandVisaAuto.exe.Config"), Path.Combine(newDir, "PolandVisaAuto.exe.Config"), true);
            File.Copy(Path.Combine(AssemblyDirectory, "pvhelper.dll"), Path.Combine(newDir, "pvhelper.dll"), true);
            File.Copy(Path.Combine(AssemblyDirectory, "DecaptcherLib.dll"), Path.Combine(newDir, "DecaptcherLib.dll"), true);
            File.Copy(Path.Combine(AssemblyDirectory, "log4net.dll"), Path.Combine(newDir, "log4net.dll"), true);
            if (File.Exists(Path.Combine(newDir, "data.xml")))
                File.Delete(Path.Combine(newDir, "data.xml"));
            VisaTask.SaveDataToFolder(tasks, Path.Combine(newDir, "data.xml"));
            
            Process process = new Process();
            process.StartInfo.FileName = Path.Combine(newDir, "PolandVisaAuto.exe");
            process.StartInfo.Arguments = "isMain 0 city " + city;
            process.Start();
        }

        private void PvAutoLoad(object sender, EventArgs e)
        {
            _commFolder = Path.Combine(AssemblyDirectory, COMM);
            if (!Directory.Exists(_commFolder))
                Directory.CreateDirectory(_commFolder);
            if (!_isMain)
                _parentFolder = Path.Combine(Environment.CurrentDirectory, COMM);
            Logger.Info("_commFolder " + _commFolder + " _parentFolder " + _parentFolder);
            ImageResolver.Instance.ChangeUseProxy += Instance_ChangeUseProxy;

            UpdateHeader();
            chbAutoResolveImage.Checked = ImageResolver.Instance.AutoResolveImage;
            radiocom.Checked = ImageResolver.Instance.Host == radiocom.Text;
            radioinfo.Checked = ImageResolver.Instance.Host == radioinfo.Text;
            chbProxy.Checked = ImageResolver.Instance.UseProxy;
            chkAsk.Checked = ImageResolver.Instance.AskMaster;

            cbxCity.DataSource = Const.GetListFromDict(Const.SettingsCities);
            cbxNation.DataSource = Const.GetListFromDict(Const.FillNations());
            cbxStatus.DataSource = Const.GetListFromDict(Const.FillStatus());
            cbxPurpose.DataSource = Const.GetListFromDict(Const.FillPurpose());
            cbxCategory.DataSource = Const.GetListFromDict(Const.GetCategoryType());
            cbxPriority.DataSource = Const.GetListPriority();

            cityDataGridViewComboBoxColumn.DataSource = Const.GetListFromDict(Const.SettingsCities);
            priorityComboBoxColumn.DataSource = Const.GetDataTablePriority();

            cbxStatus.SelectedItem = "Mr.";
            cbxNation.SelectedItem = "UKRAINE";

            _visaTasks = VisaTask.DeSerialize(VisaEntityType.New);

            dataGridView1.DataSource = _visaTasks;
            dataGridView1.Columns["deleteColumn"].DisplayIndex = 0;
            dataGridView1.Columns["duplColumn"].DisplayIndex = 1;
            dataGridView1.Columns["City"].DisplayIndex = 2;
            dataGridView1.Columns["LastName"].DisplayIndex = 3;
            dataGridView1.Columns["Name"].DisplayIndex = 4;
            dataGridView1.Columns["Status"].DisplayIndex = 5;
            dataGridView1.Refresh();

            _completedVisaTasks = VisaTask.DeSerialize(VisaEntityType.Completed);
            dataGridView2.DataSource = _completedVisaTasks;
            dataGridView2.Columns["deleteColumn2"].DisplayIndex = 0;
            dataGridView2.Columns["restoreColumn"].DisplayIndex = 1;
            dataGridView2.Columns["City2"].DisplayIndex = 2;
            dataGridView2.Columns["LastName2"].DisplayIndex = 3;
            dataGridView2.Columns["Name2"].DisplayIndex = 4;
            dataGridView2.Columns["RegistrationInfo"].DisplayIndex = 5;
            dataGridView2.Columns["Purpose"].DisplayIndex = 8;
            dataGridView2.Refresh();

            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                Engine.TabColors.Add(tabPage, Color.White);
            }
            
            _engine = new Engine(_visaTasks, tabControl1, _isMain);//, _completedVisaTasks);
            _engine.RefreshViewTabs();
            _engine.ETaskEvent += _engine_ETaskEvent;
        }
        
        void _timer_Tick(object sender, System.EventArgs e)
        {
            var files = Directory.GetFiles(_commFolder);
            foreach (string file in files)
            {
                Logger.Info("Processing file " + file);
                try
                {
                    Message mess = Message.DeSerialize(file);
                    Logger.Info("Action "+mess.Action);
                    switch (mess.Action)
                    {
                        case Actions.Create:
                            if (mess.Task != null)
                            {
                                _visaTasks.Add(mess.Task);
                                VisaTask.Save(_visaTasks, VisaEntityType.New);
                                _engine.RefreshViewTabs();
                            }
                            else 
                                Logger.Error("mess.Task is null");
                            break;
                        case Actions.Delete:
                            VisaTask taskToDelete = null;
                            foreach (VisaTask visaTask in _visaTasks)
                            {
                                if (visaTask.Receipt == mess.Task.Receipt)
                                {
                                    taskToDelete = visaTask;
                                    break;
                                }
                            }
                            if (taskToDelete != null)
                            {
                                _engine.DeleteTask(taskToDelete);
                                DeleteTask(taskToDelete);
                            }
                            else
                                Logger.Error("Can't Delete task");
                            break;
                        case Actions.Restore:
                            VisaTask taskTorestore = null;
                            foreach (VisaTask visaTask in _completedVisaTasks)
                            {
                                if (visaTask.Receipt == mess.Task.Receipt)
                                {
                                    taskTorestore = visaTask;
                                    break;
                                }
                            }
                            if (taskTorestore != null)
                            {
                                _completedVisaTasks.Remove(taskTorestore);
                                VisaTask.Save(_completedVisaTasks, VisaEntityType.Completed);
                                _visaTasks.Add(taskTorestore);
                                VisaTask.Save(_visaTasks, VisaEntityType.New);
                                Logger.Info("_engine.RefreshViewTabs()");
                                _engine.RefreshViewTabs();
                            }
                            else
                            {
                                _visaTasks.Add(mess.Task);
                                Logger.Error("Can't Restore task");
                            }
                            break;
                        case Actions.Remove:
                            VisaTask taskToremove = null;
                            foreach (VisaTask visaTask in _completedVisaTasks)
                            {
                                if (visaTask.Receipt == mess.Task.Receipt)
                                {
                                    taskToremove = visaTask;
                                    break;
                                }
                            }
                            if (taskToremove != null)
                            {
                                _completedVisaTasks.Remove(taskToremove);
                                VisaTask.Save(_completedVisaTasks, VisaEntityType.Completed);
                            }
                            else
                                Logger.Error("Can't Remove task");
                            break;
                    }
                    File.Delete(file);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                }
            }
        }

        void PVAutoFill_Shown(object sender, System.EventArgs e)
        {
            if (_isMain)
                CreateMainCityInfo();
            _timer.Start();
        }

        void Instance_ChangeUseProxy(bool useProxy)
        {
            chbProxy.Checked = useProxy;
        }

        void _engine_ETaskEvent(VisaTask task)
        {
            WriteReportFile(task);
            DeleteTask(task);
            SendMessage(task, Actions.Delete);
        }

        private void WriteReportFile(VisaTask task)
        {
            var repPath = Path.Combine(AssemblyDirectory, "Reports");
            if (!Directory.Exists(repPath))
                Directory.CreateDirectory(repPath);
            File.WriteAllLines(Path.Combine(repPath, task.GetFullNameAsFileName()),
                               new[]
                                   {
                                       task.LastName + " " + task.Name,
                                       "Password: " + task.Email + " " + task.Password,
                                       task.RegistrationInfo
                                   });
        }

        private string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        private void UpdateHeader()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            this.Text += version+ "   De-Captcher Balance: "+ ImageResolver.Instance.GetBalance() + "$";
        }

        public void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            using (Brush br = new SolidBrush(Engine.TabColors[tabControl1.TabPages[e.Index]]))
            {
                e.Graphics.FillRectangle(br, e.Bounds);
                SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, e.Font);
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

                Rectangle rect = e.Bounds;
                rect.Offset(0, 1);
                rect.Inflate(0, -1);
                e.Graphics.DrawRectangle(Pens.Gainsboro, rect);
                e.DrawFocusRectangle();
            }
        }
        private void txtEmail_Validated(object sender, EventArgs e)
        {
              if (!VisaTask.IsValidEmailAddress(txtEmail.Text))
                  emailErrorProvider.SetError(txtEmail, "Не правильный email");
              else
                  emailErrorProvider.SetError(txtEmail, string.Empty);
        }

        private void txtPass_Validated(object sender, EventArgs e)
        {
            if (!VisaTask.IsValidPassword(txtPass.Text))
                PasserrorProvider.SetError(txtPass, "Пароль должен содержать не менее 8 символов");
            else
                PasserrorProvider.SetError(txtPass, string.Empty);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dataGridView1.Columns["deleteColumn"].Index)
            {
                VisaTask vt = dataGridView1.Rows[e.RowIndex].DataBoundItem as VisaTask;
                Logger.Warning("Удаляю задание " + vt.GetInfo());
                _engine.DeleteTask(vt);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                DeleteTask(vt);
                SendMessage(vt, Actions.Delete);
            }
            if (e.ColumnIndex == dataGridView1.Columns["duplColumn"].Index)
            {
                var currItem = (VisaTask)dataGridView1.CurrentRow.DataBoundItem;
                using (DuplForm form = new DuplForm())
                {
                    form.FillCombo(Const.GetListFromDict(Const.SettingsCities));
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        VisaTask vt = currItem.Clone();
                        vt.City = form.GetSelectedCity();
                        vt.CityCode = Const.CityCodeByCity(vt.City);
                        _visaTasks.Add(vt);
                        VisaTask.Save(_visaTasks, VisaEntityType.New);
                        _engine.RefreshViewTabs();
                        SendMessage(vt, Actions.Create);
                    }
                }
            }
        }

        private void DeleteTask(VisaTask vt)
        {
            _visaTasks.Remove(vt);
            VisaTask.Save(_visaTasks, VisaEntityType.New);
            _completedVisaTasks.Add(vt);
            VisaTask.Save(_completedVisaTasks, VisaEntityType.Completed);
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
                return;
            if (e.ColumnIndex == dataGridView1.Columns["City"].Index)
            {
                _cityBefore = ((VisaTask)dataGridView1.CurrentRow.DataBoundItem).CityV;
            }
        }
       
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
                return;
            if (e.ColumnIndex == dataGridView1.Columns["City"].Index)
            {
                var currItem = (VisaTask)dataGridView1.CurrentRow.DataBoundItem;
                var prevItem = currItem.Clone();
                prevItem.City = _cityBefore.Substring(_cityBefore.IndexOf(")")+1);
                SendMessage(prevItem, Actions.Delete);
                currItem.CityCode = Const.CityCodeByCity(dataGridView1.CurrentCell.Value.ToString());
                SendMessage(currItem, Actions.Create);

                Logger.Info(string.Format("Город изменен с {0} на {1}", _cityBefore, currItem.City));
                TabPage tp1 = null;
                TabPage tp2 = null;
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    string tabtextClear = tab.Text;
                    if (tab.Text.IndexOf("~") != -1)
                        tabtextClear = tab.Text.Remove(tab.Text.IndexOf("~"));

                    if (_cityBefore.Equals(tabtextClear))
                    {
                        tp1 = tab;
                    }
                    else if (currItem.CityV.Equals(tabtextClear))
                    {
                        tp2 = tab;
                    }
                }

                if (tp1 != null)
                {
                    tabControl1.TabPages.Remove(tp1);
                    _engine.DeleteCityKey(_cityBefore);
                }
                if (tp2 != null)
                {
                    tabControl1.TabPages.Remove(tp2);
                    _engine.DeleteCityKey(currItem.CityV);
                }
                _cityBefore = string.Empty;
                _engine.RefreshViewTabs();
                VisaTask.Save(_visaTasks, VisaEntityType.New);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["priorityComboBoxColumn"].Index)
            {
                VisaTask.Save(_visaTasks, VisaEntityType.New);
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dataGridView2.Columns["deleteColumn2"].Index)
            {
                VisaTask vt = dataGridView2.Rows[e.RowIndex].DataBoundItem as VisaTask;
                Logger.Warning("Удаляю завершенное/удаленное задание " + vt.GetInfo());
                dataGridView2.Rows.RemoveAt(e.RowIndex);
                VisaTask.Save(_completedVisaTasks, VisaEntityType.Completed);
                vt.Save();
                SendMessage(vt, Actions.Remove);
            }
            else if (e.ColumnIndex == dataGridView2.Columns["restoreColumn"].Index)
            {
                VisaTask vt = dataGridView2.Rows[e.RowIndex].DataBoundItem as VisaTask;
                Logger.Warning("Восстанавливаю завершенное/удаленное задание " + vt.GetInfo());
                dataGridView2.Rows.RemoveAt(e.RowIndex);
                VisaTask.Save(_completedVisaTasks, VisaEntityType.Completed);
                _visaTasks.Add(vt);
                VisaTask.Save(_visaTasks, VisaEntityType.New);
                _engine.RefreshViewTabs();
                SendMessage(vt, Actions.Restore);
            }
        }

        private void btnCreateEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Format("{0}@gmeil.com", txtLastName.Text+txtName.Text);
            txtPass.Text = Guid.NewGuid().ToString().Replace("-","").Remove(8);
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if(rb != null && rb.Checked)
            {
                ImageResolver.Instance.Host = rb.Text;
                UpdateSetting(Const.HOST, ImageResolver.Instance.Host);
            }
        }

        void restoreButton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Path.Combine(AssemblyDirectory, Const.DELETEDTASKS);
            dlg.Multiselect = false;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    VisaTask vt = VisaTask.DeSerialize(dlg.FileName);
                    _visaTasks.Add(vt);
                    VisaTask.Save(_visaTasks, VisaEntityType.New);
                    _engine.RefreshViewTabs();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Ошибка!");
                }
            }
        }

        private void chbAutoResolveImage_CheckedChanged(object sender, EventArgs e)
        {
            ImageResolver.Instance.AutoResolveImage = chbAutoResolveImage.Checked;
            UpdateSetting(Const.AUTORESOLVE, ImageResolver.Instance.AutoResolveImage.ToString());
        }

        private static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void chbProxy_CheckedChanged(object sender, EventArgs e)
        {
            ImageResolver.Instance.UseProxy = chbProxy.Checked;
            UpdateSetting(Const.USEPROXY, ImageResolver.Instance.UseProxy.ToString());
        }

        private void chkAsk_CheckedChanged(object sender, EventArgs e)
        {
            ImageResolver.Instance.AskMaster = chkAsk.Checked;
            UpdateSetting(Const.ASKMASTER, ImageResolver.Instance.AskMaster.ToString());
        }

        #region Export To Excel

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var ci = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

              //  Int16 i, j;

                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet) xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "Основные задания";
                WriteCells(xlWorkSheet, dataGridView1);
//                for (i = 0; i < dataGridView1.RowCount; i++)
//                {
//                    for (j = 0; j < dataGridView1.ColumnCount; j++)
//                    {
//                        xlWorkSheet.Cells[i + 1, j + 1] = dataGridView1[j, i].Value == null
//                            ? ""
//                            : dataGridView1[j, i].Value.ToString();
//                    }
//                }

                xlWorkSheet = (Excel.Worksheet) xlWorkBook.Worksheets.get_Item(2);
                xlWorkSheet.Name = "Удаленные задания";
                WriteCells(xlWorkSheet, dataGridView2);
//                for (i = 0; i < dataGridView2.RowCount; i++)
//                {
//                    for (j = 0; j < dataGridView2.ColumnCount; j++)
//                    {
//                        xlWorkSheet.Cells[i + 1, j + 1] = dataGridView2[j, i].Value == null
//                            ? ""
//                            : dataGridView2[j, i].Value.ToString();
//                    }
//                }

                string path = Path.Combine(AssemblyDirectory, "Export");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                var file = Path.Combine(path,string.Format("export_{0}.xls",DateTime.Now.ToString(Const.DateFormatForFile, CultureInfo.InvariantCulture)));
                xlWorkBook.SaveAs(file,Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                Thread.CurrentThread.CurrentCulture = ci;
                MessageBox.Show("Файл \r\n" + file + "\r\n успешно экспортирован!");
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }

        private void WriteCells(Excel.Worksheet xlWorkSheet, DataGridView dataGridView)
        {
            Excel.Range cells = xlWorkSheet.Cells;
            // set each cell's format to Text
            cells.NumberFormat = "@";
            Int16 i = 0;
            xlWorkSheet.Cells[i + 1, 1] = "Город";
            xlWorkSheet.Cells[i + 1, 2] = "Имя";
            xlWorkSheet.Cells[i + 1, 3] = "Фамилия";
            xlWorkSheet.Cells[i + 1, 4] = "Дата рожд";
            xlWorkSheet.Cells[i + 1, 5] = "Паспорт";
            xlWorkSheet.Cells[i + 1, 6] = "Дата окончания";
            xlWorkSheet.Cells[i + 1, 7] = "Код";
            xlWorkSheet.Cells[i + 1, 8] = "Начало регистрации";
            xlWorkSheet.Cells[i + 1, 9] = "Конец регистрации";
            xlWorkSheet.Cells[i + 1, 10] = "Mыло";
            xlWorkSheet.Cells[i + 1, 11] = "Пароль";

            for (i = 0; i < dataGridView.RowCount; i++)
            {
                xlWorkSheet.Cells[i + 2, 1] = dataGridView[2, i].Value == null ? "" : dataGridView[2, i].Value.ToString();
                xlWorkSheet.Cells[i + 2, 2] = dataGridView[12, i].Value == null ? "" : dataGridView[12, i].Value.ToString();
                xlWorkSheet.Cells[i + 2, 3] = dataGridView[13, i].Value == null ? "" : dataGridView[13, i].Value.ToString();
                xlWorkSheet.Cells[i + 2, 4] = dataGridView[14, i].Value == null ? "" : dataGridView[14, i].Value.ToString();
                //xlWorkSheet.Cells[i + 2, 5] = "";
                xlWorkSheet.Cells[i + 2, 6] = dataGridView[10, i].Value == null ? "" : dataGridView[10, i].Value.ToString();
                xlWorkSheet.Cells[i + 2, 7] = dataGridView[7, i].Value == null ? "" : dataGridView[7, i].Value.ToString();
                xlWorkSheet.Cells[i + 2, 8] = dataGridView[19, i].Value == null ? "" : dataGridView[19, i].Value.ToString();
                xlWorkSheet.Cells[i + 2, 9] = dataGridView[18, i].Value == null ? "" : dataGridView[18, i].Value.ToString();
                xlWorkSheet.Cells[i + 2, 10] = dataGridView[8, i].Value == null ? "" : dataGridView[8, i].Value.ToString();
                xlWorkSheet.Cells[i + 2, 11] = dataGridView[9, i].Value == null ? "" : dataGridView[9, i].Value.ToString();
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        #endregion

        #region Process
        private bool CheckOnProcessExists(string city)
        {
            string wmiQuery = string.Format("select CommandLine from Win32_Process where Name='{0}'", GetActiveProcessFileName());
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmiQuery);
            ManagementObjectCollection retObjectCollection = searcher.Get();
            foreach (ManagementObject retObject in retObjectCollection)
            {
                if (retObject["CommandLine"].ToString().Contains(city))
                    return true;
            }
            return false;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private string GetActiveProcessFileName()
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            return Path.GetFileName(p.MainModule.FileName);
        }

        #endregion
    }
}
