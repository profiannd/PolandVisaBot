using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class Schengen_visasData : UserControl
    {
        public Schengen_visasData()
        {
            InitializeComponent();
        }
        public bool YNVisa
        {
            get { return radioYes.Checked; }
            set
            {
                radioYes.Checked = value;
                radioNo.Checked = !value;
            }
        }

        public DateTime From1Visa
        {
            get { return dtFrom1.Value; }
            set { dtFrom1.Value = value; }
        }
        public DateTime From2Visa
        {
            get { return dtFrom2.Value; }
            set { dtFrom2.Value = value; }
        }
        public DateTime To1Visa
        {
            get { return dtTo1.Value; }
            set { dtTo1.Value = value; }
        }
        public DateTime To2Visa
        {
            get { return dtTo2.Value; }
            set { dtTo2.Value = value; }
        }

        private void Schengen_visasData_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
