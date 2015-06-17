using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class ChildData : UserControl
    {
        public ChildData()
        {
            InitializeComponent();
        }

        public string CitizenshipChild
        {
            get { return txtCitizenship.Text; }
            set { txtCitizenship.Text = value; }
        }
        public string FirstNameChild
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public string LastNameChild
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }
        public string CountryChild
        {
            get { return txtCountry.Text; }
            set { txtCountry.Text = value; }
        }
        public string StateChild
        {
            get { return txtState.Text; }
            set { txtState.Text = value; }
        }
        public string CityChild
        {
            get { return txtCity.Text; }
            set { txtCity.Text = value; }
        }
        public string ZipChild
        {
            get { return txtZip.Text; }
            set { txtZip.Text = value; }
        }
        public string AddressChild
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
    }
}
