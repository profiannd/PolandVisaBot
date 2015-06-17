using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class TheseEUCitizenData : UserControl
    {
        public TheseEUCitizenData()
        {
            InitializeComponent();
        }

        public string LastNameEuCitizen
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string NameEuCitizen
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string PassNumberEuCitizen
        {
            get { return txtPassportNumber.Text; }
            set { txtPassportNumber.Text = value; }
        }

        public DateTime DobEuCitizen
        {
            get { return dtDob.Value; }
            set { dtDob.Value = value; }
        }
        public string KinRadioEuCitizen
        {
            get
            {
                for (int index = 0; index < gBKinState.Controls.Count; index++)
                {
                    RadioButton rb = gBKinState.Controls[index] as RadioButton;
                    if (rb != null && rb.Checked)
                        return rb.Name;
                }
                return "";
            }
            set
            {
                for (int index = 0; index < gBKinState.Controls.Count; index++)
                {
                    RadioButton rb = gBKinState.Controls[index] as RadioButton;
                    if (rb != null && rb.Name == value)
                    {
                        rb.Checked = true;
                        break;
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
