using System;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class TargetData : UserControl
    {
        public TargetData()
        {
            InitializeComponent();
        }

        public bool TourismTarget
        {
            get { return chkTourism.Checked; }
            set { chkTourism.Checked = value; }
        }

        public bool DealTarget
        {
            get { return chkDeal.Checked; }
            set { chkDeal.Checked = value; }
        }
        public bool FamilyTarget
        {
            get { return chkFamily.Checked; }
            set { chkFamily.Checked = value; }
        }
        public bool CultureTarget
        {
            get { return chkCulture.Checked; }
            set { chkCulture.Checked = value; }
        }
        public bool SportTarget
        {
            get { return chkSport.Checked; }
            set { chkSport.Checked = value; }
        }
        public bool OfficialTarget
        {
            get { return chkOfficial.Checked; }
            set { chkOfficial.Checked = value; }
        }
        public bool TreatmentTarget
        {
            get { return chkTreatment.Checked; }
            set { chkTreatment.Checked = value; }
        }
        public bool LearningTarget
        {
            get { return chkLearning.Checked; }
            set { chkLearning.Checked = value; }
        }
        public bool OtherTarget
        {
            get { return chkOther.Checked; }
            set { chkOther.Checked = value; }
        }
        public string TextOtherTarget
        {
            get { return txtOther.Text; }
            set { txtOther.Text = value; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFamily_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
