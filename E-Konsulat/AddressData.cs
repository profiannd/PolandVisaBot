using System;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class AddressData : UserControl
    {
        public AddressData()
        {
            InitializeComponent();
        }

        public string CountryAddress
        {
            get { return txtCountry.Text; }
            set { txtCountry.Text = value; }
        }
        public string StateAddress
        {
            get { return txtState.Text; }
            set { txtState.Text = value; }
        }
        public string CityAddress
        {
            get { return txtCity.Text; }
            set { txtCity.Text = value; }
        }
        public string ZipAddress
        {
            get { return txtZip.Text; }
            set { txtZip.Text = value; }
        }
        public string AddressAddress
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public string EmailAddress
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string PrefixAddress
        {
            get { return txtPrefix.Text; }
            set { txtPrefix.Text = value; }
        }
        public string TelNumberAddress
        {
            get { return txtTelNumber.Text; }
            set { txtTelNumber.Text = value; }
        }
    }
}
