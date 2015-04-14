using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using pvhelper;

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
            UpdateHeader();
            chbAutoResolveImage.Checked = ImageResolver.Instance.AutoResolveImage;
            radiocom.Checked = ImageResolver.Instance.Host == radiocom.Text;
            radioinfo.Checked = ImageResolver.Instance.Host == radioinfo.Text;
            chbProxy.Checked = ImageResolver.Instance.UseProxy;

            cbxCity.DataSource = Const.GetListFromDict(Const.SettingsCities);
            cbxNation.DataSource = Const.GetListFromDict(Const.FillNations());
            cbxStatus.DataSource = Const.GetListFromDict(Const.FillStatus());
            cbxPurpose.DataSource = Const.GetListFromDict(Const.FillPurpose());
            cbxCategory.DataSource = Const.GetListFromDict(Const.GetCategoryType());
            cityDataGridViewComboBoxColumn.DataSource = Const.GetListFromDict(Const.SettingsCities);

            cbxPriority.DataSource = Const.GetListPriority();

            cbxStatus.SelectedItem = "Mr.";
            cbxNation.SelectedItem = "UKRAINE";

            _visaTasks = VisaTask.DeSerialize(VisaEntityType.New);

            dataGridView1.DataSource = _visaTasks;
            dataGridView1.Columns["deleteColumn"].DisplayIndex = 0;
            dataGridView1.Columns["City"].DisplayIndex = 1;
            dataGridView1.Columns["LastName"].DisplayIndex = 2;
            dataGridView1.Columns["Name"].DisplayIndex = 3;
            dataGridView1.Columns["Status"].DisplayIndex = 4;
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
            _engine.SetProxy();
            _engine.RefreshViewTabs();
            _engine.ETaskEvent += _engine_ETaskEvent;
        }

        void _engine_ETaskEvent(VisaTask task)
        {
            RemoveTask(task);
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
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["deleteColumn"].Index)
                return;
            VisaTask vt = dataGridView1.Rows[e.RowIndex].DataBoundItem as VisaTask;
            Logger.Warning("Удаляю задание "+ vt.GetInfo());
            _engine.DeleteTask(vt);
            dataGridView1.Rows.RemoveAt(e.RowIndex);
            RemoveTask(vt);
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
                _cityBefore = dataGridView1.CurrentCell.Value.ToString();
            }
        }
       
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
                return;
            if (e.ColumnIndex == dataGridView1.Columns["City"].Index)
            {
                var currItem = (VisaTask)dataGridView1.CurrentRow.DataBoundItem;
                
                var currentCity = dataGridView1.CurrentCell.Value.ToString();
                currItem.CityCode = Const.CityCodeByCity(currentCity);

                Logger.Info(string.Format("Город изменен с {0} на {1}", _cityBefore, currentCity));
                TabPage tp1 = null;
                TabPage tp2 = null;
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    if (_cityBefore.Equals(tab.Name))
                    {
                        tp1 = tab;
                    }
                    else if (currentCity.Equals(tab.Name))
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
                    _engine.DeleteCityKey(currentCity);
                }
                _cityBefore = string.Empty;
                _engine.RefreshViewTabs();
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
            txtEmail.Text = string.Format("{0}@gmail.com", txtLastName.Text);
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
    }
}
