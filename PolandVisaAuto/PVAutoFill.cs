using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
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
        private Engine _engine;
//        SoundPlayer sp;

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
            _visaTasks.Add(task);
            VisaTask.Save(_visaTasks);
            dataGridView1.Refresh();

            _engine.RefreshViewTabs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            this.Text += version;

            cbxCity.DataSource = Const.GetListFromDict(Const.SettingsCities);
            cbxNation.DataSource = Const.GetListFromDict(Const.FillNations());
            cbxStatus.DataSource = Const.GetListFromDict(Const.FillStatus());
            cbxPurpose.DataSource = Const.GetListFromDict(Const.FillPurpose());
            cbxCategory.DataSource = Const.GetListFromDict(Const.GetCategoryType());
            
            cbxPriority.DataSource = Const.GetListPriority();

            cbxStatus.SelectedItem = "Mr.";
            cbxNation.SelectedItem = "Ukrainians";

            _visaTasks = VisaTask.DeSerialize();
            dataGridView1.DataSource = _visaTasks;
            dataGridView1.Refresh();

            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                Engine.TabColors.Add(tabPage, Color.White);
            }
            _engine = new Engine(_visaTasks, tabControl1);
            _engine.RefreshViewTabs();
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

            _engine.DeleteTask(dataGridView1.Rows[e.RowIndex].DataBoundItem as VisaTask);
            dataGridView1.Rows.RemoveAt(e.RowIndex);
            VisaTask.Save(_visaTasks);
        }
    }
}
