using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using pvhelper;
using Excel = Microsoft.Office.Interop.Excel;

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
        public const string DateFormat = "dd/MM/yyyy";
        private BindingList<VisaTask> _visaTasks;
        private BindingList<VisaTask> _completedVisaTasks;
        private string _cityBefore = string.Empty;
        private Engine _engine;

        public PVAutoFill()
        {
            InitializeComponent();
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
            
            _engine.RefreshViewTabs();

            txtPass.Text = txtName.Text = txtBillNum.Text = txtEmail.Text = txtLastName.Text = txtName.Text = string.Empty;
        }

        private void PvAutoLoad(object sender, EventArgs e)
        {
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
            _engine = new Engine(_visaTasks, tabControl1);//, _completedVisaTasks);
            //!! 
           // _engine.SetProxy();
            _engine.RefreshViewTabs();
            _engine.ETaskEvent += _engine_ETaskEvent;
        }

        void Instance_ChangeUseProxy(bool useProxy)
        {
            chbProxy.Checked = useProxy;
        }

        void _engine_ETaskEvent(VisaTask task)
        {
            WriteReportFile(task);
            RemoveTask(task);
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
                RemoveTask(vt);
            }
            if (e.ColumnIndex == dataGridView1.Columns["duplColumn"].Index)
            {
                var currItem = (VisaTask)dataGridView1.CurrentRow.DataBoundItem;
                DuplForm form = new DuplForm();
                form.FillCombo(Const.GetListFromDict(Const.SettingsCities));
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    VisaTask vt = currItem.Clone();
                    vt.City = form.GetSelectedCity();
                    vt.CityCode = Const.CityCodeByCity(vt.City);
                    _visaTasks.Add(vt);
                    VisaTask.Save(_visaTasks, VisaEntityType.New);
                    _engine.RefreshViewTabs();
                }
                form.Dispose();
            }
        }

        private void RemoveTask(VisaTask vt)
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
                currItem.CityCode = Const.CityCodeByCity(dataGridView1.CurrentCell.Value.ToString());


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
    }
}
