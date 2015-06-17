using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class FingerprintsData : UserControl
    {
        public FingerprintsData()
        {
            InitializeComponent();
        }
        public bool FingYNFingerprints
        {
            get { return radioYes.Checked; }
            set
            {
                radioYes.Checked = value;
                radioNo.Checked = !value;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
