using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace E_Konsulat
{
    public partial class InformationData : UserControl
    {
        public InformationData()
        {
            InitializeComponent();
        }

        public string DestinationInform
        {
            get { return txtDestination.Text; }
            set { txtDestination.Text = value; }
        }
        public string WaiverInform
        {
            get { return txtWaiver.Text; }
            set { txtWaiver.Text = value; }
        }
        public string NumbDayInform
        {
            get { return txtNumbDay.Text; }
            set { txtNumbDay.Text = value; }
        }
        public DateTime ArrivalInform
        {
            get { return dtArrival.Value; }
            set { dtArrival.Value = value; }
        }
        public DateTime CheckOutInform
        {
            get { return dtCheckOut.Value; }
            set { dtCheckOut.Value = value; }
        }

        public string EntryStateRadioInform
        {
            get
            {
                for (int index = 0; index < gBInformation.Controls.Count; index++)
                {
                    RadioButton rb = gBInformation.Controls[index] as RadioButton;
                    if (rb != null && rb.Checked)
                        return rb.Name;
                }
                return "";
            }
            set
            {
                for (int index = 0; index < gBInformation.Controls.Count; index++)
                {
                    RadioButton rb = gBInformation.Controls[index] as RadioButton;
                    if (rb != null && rb.Name == value)
                    {
                        rb.Checked = true;
                        break;
                    }
                }
            }
        }
    }
}
