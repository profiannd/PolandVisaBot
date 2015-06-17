using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class InfreceivingData : UserControl
    {
        public InfreceivingData()
        {
            InitializeComponent();
        }

        public bool FirmManRadioInferec
        {
            get { return radioMan.Checked; }
            set
            {
                radioMan.Checked = value;
                radioFirm.Checked = !value;
            }
        }

        public string TitleInferec
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }
        public string NameInferec
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public string LastNameInferec
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }
        public string StateInferec
        {
            get { return txtState.Text; }
            set { txtState.Text = value; }
        }
        public string CityInferec
        {
            get { return txtCity.Text; }
            set { txtCity.Text = value; }
        }
        public string PostcodeInferec
        {
            get { return txtPostcode.Text; }
            set { txtPostcode.Text = value; }
        }
        public string PrefixInferec
        {
            get { return txtPrefix.Text; }
            set { txtPrefix.Text = value; }
        }
        public string TelNumberInferec
        {
            get { return txtTelNumber.Text; }
            set { txtTelNumber.Text = value; }
        }
        public string FaxPrefixInferec
        {
            get { return txtFaxPrefix.Text; }
            set { txtFaxPrefix.Text = value; }
        }
        public string FaxInferec
        {
            get { return txtFax.Text; }
            set { txtFax.Text = value; }
        }
        public string AddressInferec
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public string HouseNumberInferec
        {
            get { return txtHouseNumber.Text; }
            set { txtHouseNumber.Text = value; }
        }
        public string ApNumberInferec
        {
            get { return txtApNumber.Text; }
            set { txtApNumber.Text = value; }
        }
        public string EmailInferec
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
