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

        public string LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string PreviousLastName
        {
            get { return txtPrevLastName.Text; }
            set { txtPrevLastName.Text = value; }
        }

        public string FirstName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public DateTime Dob
        {
            get { return dtDob.Value; }
            set { dtDob.Value = value; }
        }

        public string DobCity
        {
            get { return txtBirthPlace.Text; }
            set { txtBirthPlace.Text = value; }
        }
        public string DobCountry
        {
            get { return txtBirthCountry.Text; }
            set { txtBirthCountry.Text = value; }
        }
        public string Citizenship
        {
            get { return txtCitizenshipNow.Text; }
            set { txtCitizenshipNow.Text = value; }
        }
        public string Nationality
        {
            get { return txtDobNationality.Text; }
            set { txtDobNationality.Text = value; }
        }

        public bool SexMRadio
        {
            get { return radioSexM.Checked; }
            set
            {
                radioSexM.Checked = value;
                radioSexF.Checked = !value;
            }
        }
        public string FamilyStateRadio
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
