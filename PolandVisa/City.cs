using System;
using System.ComponentModel;
using System.Globalization;
using pvhelper;

namespace PolandVisaMonitor
{
    public class CityData : INotifyPropertyChanged
    {
        private string _city;
        protected DateTime _date;
        protected bool _isSelected;
        private string _cityCode = "";

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        
        [Browsable(false)] 
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string DateStr
        {
            get
            {
                if (Date == DateTime.MinValue)
                    return string.Empty;
                return Date.ToString(Const.DateFormat, CultureInfo.InvariantCulture);
            }
            set { _date = DateTime.ParseExact(value, Const.DateFormat, CultureInfo.InvariantCulture); }
        }

        [Browsable(false)] 
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }
        [Browsable(false)] 
        public string CityCode
        {
            set { _cityCode = value; }
            get { return _cityCode; }
        }
        [Browsable(false)] 
        public string WriteToString
        {
            get { return string.Format("{0}|{1}|{2}", _cityCode, DateStr, IsSelected ? "1" : "0"); }
        }

        public string getMessage()
        {
            return string.Format("{0} ждет оформления визы {1}!", City, DateStr);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

     public class CityDataSet : CityData
     {
         public bool IsChecked
         {
             get { return _isSelected; }
             set { _isSelected = value; }
         }
     }
}
