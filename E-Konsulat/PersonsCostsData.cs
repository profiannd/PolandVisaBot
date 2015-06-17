using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class PersonsCostsData : UserControl
    {
        public PersonsCostsData()
        {
            InitializeComponent();
        }

        public bool CostRadioPersCost
        {
            get { return radioHim.Checked; }
            set
            {
                radioHim.Checked = value;
                radioSponsors.Checked = !value;
            }
        }

        public bool ReferredPersCost
        {
            get { return chkReferred.Checked; }
            set { chkReferred.Checked = value; }
        }
        public bool OtherPersCost
        {
            get { return chkOther.Checked; }
            set { chkOther.Checked = value; }
        }
        public bool MoneyPersCost
        {
            get { return chkMoney.Checked; }
            set { chkMoney.Checked = value; }
        }
        public bool ChecksPersCost
        {
            get { return chkChecks.Checked; }
            set { chkChecks.Checked = value; }
        }
        public bool CardPersCost
        {
            get { return chkCard.Checked; }
            set { chkCard.Checked = value; }
        }
        public bool AllCostsPersCost
        {
            get { return chkAllCosts.Checked; }
            set { chkAllCosts.Checked = value; }
        }
        public bool OtherCostsPersCost
        {
            get { return chkOtherCosts.Checked; }
            set { chkOtherCosts.Checked = value; }
        }
        public bool LocationPersCost
        {
            get { return chkLocation.Checked; }
            set { chkLocation.Checked = value; }
        }
        public bool TransportPersCost
        {
            get { return chkTransport.Checked; }
            set { chkTransport.Checked = value; }
        }
        public bool InsurancePersCost
        {
            get { return chkInsurance.Checked; }
            set { chkInsurance.Checked = value; }
        }
        public string OthePersCost
        {
            get { return txtOther.Text; }
            set { txtOther.Text = value; }
        }
        public string OtheCostsPersCost
        {
            get { return txtOtherCosts.Text; }
            set { txtOtherCosts.Text = value;}
        }

        public DateTime DateInsurancePersCost
        {
            get { return dtInsurance.Value; }
            set { dtInsurance.Value = value; }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
