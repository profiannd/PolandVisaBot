using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        public void okCancelControl1_OnCancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void okCancelControl1_OnOk(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
