using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class BossAddressData : UserControl
    {
        public BossAddressData()
        {
            InitializeComponent();
        }

        public string CountryBossAddress
        {
            get { return txtCountry.Text; }
            set { txtCountry.Text = value; }
        }
        public string StateBossAddress
        {
            get { return txtState.Text; }
            set { txtState.Text = value; }
        }
        public string CityBossAddress
        {
            get { return txtCity.Text; }
            set { txtCity.Text = value; }
        }
        public string ZipBossAddress
        {
            get { return txtZip.Text; }
            set { txtZip.Text = value; }
        }
        public string AddressBossAddress
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public string EmailBossAddress
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string PrefixBossAddress
        {
            get { return txtPrefix.Text; }
            set { txtPrefix.Text = value; }
        }
        public string TelNumberBossAddress
        {
            get { return txtTelNumber.Text; }
            set { txtTelNumber.Text = value; }
        }

        public string FaxBossAddress
        {
            get { return txtFax.Text; }
            set { txtFax.Text = value; }
        }

        public string FaxPrefixBossAddress
        {
            get { return txtFaxPrefix.Text; }
            set { txtFaxPrefix.Text = value; }
        }

        public bool BLRadioBossAddress
        {
            get { return radioBoss.Checked; }
            set
            {
                radioBoss.Checked = value;
                radioLearn.Checked = !value;
            }
        }
    }
    
}
