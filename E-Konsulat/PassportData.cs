using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class PassportData : UserControl
    {
        public PassportData()
        {
            InitializeComponent();
        }

        public string PassportNumber
        {
            get { return txtPassNumber.Text; }
            set { txtPassNumber.Text = value; }
        }

        public DateTime PassportFromDate
        {
            get { return dtFrom.Value; }
            set { dtFrom.Value = value; }
        }

        public DateTime PassportToDate
        {
            get { return dtTo.Value; }
            set { dtTo.Value = value; }
        }

        public string PassportSource
        {
            get { return txtWhom.Text; }
            set { txtWhom.Text = value; }
        }

        public string PassportTypeRadio
        {
            get
            {
                for (int index = 0; index < gbPassportType.Controls.Count; index++)
                {
                    RadioButton rb = gbPassportType.Controls[index] as RadioButton;
                    if (rb != null && rb.Checked)
                        return rb.Name;
                }
                return "";
            }
            set
            {
                for (int index = 0; index < gbPassportType.Controls.Count; index++)
                {
                    RadioButton rb = gbPassportType.Controls[index] as RadioButton;
                    if (rb != null && rb.Name == value)
                    {
                        rb.Checked = true;
                        break;
                    }
                }
            }
        }

        private void radioAnother_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Name == "radioAnother")
                    txtAnother.Enabled = true;
                else
                {
                    txtAnother.Enabled = false;
                }
            }
            
        }
    }
}
