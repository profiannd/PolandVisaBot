using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class OkCancelControl : UserControl
    {
        public event EventHandler OnOk;
        public event EventHandler OnCancel;

        public OkCancelControl()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (OnOk != null)
            {
                OnOk(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (OnCancel != null)
            {
                OnCancel(sender, e);
            }
        }
    }
}
