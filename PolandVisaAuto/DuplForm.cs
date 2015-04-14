using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PolandVisaAuto
{
    public partial class DuplForm : Form
    {
        public DuplForm()
        {
            InitializeComponent();
        }

        public void FillCombo(List<string> dsource)
        {
            comboBox1.DataSource = dsource;
        }

        public string GetSelectedCity()
        {
            return comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
