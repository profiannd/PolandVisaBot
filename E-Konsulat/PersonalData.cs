using System;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class PersonalData : UserControl
    {
        public PersonalData()
        {
            InitializeComponent();
        }

        public string LastNamePersonal
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string PreviousLastNamePersonal
        {
            get { return txtPrevLastName.Text; }
            set { txtPrevLastName.Text = value; }
        }

        public string FirstNamePersonal
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public DateTime DobPersonal
        {
            get { return dtDob.Value; }
            set { dtDob.Value = value; }
        }

        public string DobCityPersonal
        {
            get { return txtBirthPlace.Text; }
            set { txtBirthPlace.Text = value; }
        }
        public string DobCountryPersonal
        {
            get { return txtBirthCountry.Text; }
            set { txtBirthCountry.Text = value; }
        }
        public string CitizenshipPersonal
        {
            get { return txtCitizenshipNow.Text; }
            set { txtCitizenshipNow.Text = value; }
        }
        public string NationalityPersonal
        {
            get { return txtDobNationality.Text; }
            set { txtDobNationality.Text = value; }
        }

        public bool SexMRadioPersonal
        {
            get { return radioSexM.Checked; }
            set
            {
                radioSexM.Checked = value;
                radioSexF.Checked = !value;
            }
        }
        public string FamilyStateRadioPersonal
        {
            get
            {
                foreach (RadioButton rb in gBFamilyState.Controls)
                {
                    if (rb.Checked)
                        return rb.Name;
                }
                return "";
            }
            set
            {
                foreach (RadioButton rb in gBFamilyState.Controls)
                {
                    if (rb.Name == value)
                    {
                        rb.Checked = true;
                        break;
                    }
                }
            }
        }
    }
}
