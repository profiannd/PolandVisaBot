using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class CountryData : UserControl
    {
        public CountryData()
        {
            InitializeComponent();
        }
        public bool DocumentRadioCountry
        {
            get { return radioNo.Checked; }
            set
            {
                radioNo.Checked = value;
                radioYes.Checked = !value;
            }
        }

        public DateTime FromCountry
        {
            get { return dtFrom.Value; }
            set { dtFrom.Value = value; }
        }

        public string PassNumber
        {
            get { return txtPassNumber.Text; }
            set { txtPassNumber.Text = value; }
        }
    }
}
