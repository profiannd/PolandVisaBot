using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Xml.Serialization;
using PolandVisaAuto.Annotations;
using pvhelper;

namespace PolandVisaAuto
{
    public class VisaTask : INotifyPropertyChanged
    {
        public string City { get; set; }
        [Browsable(false)]
        public string CityCode { get; set; }
        public string Purpose { get; set; }
        [Browsable(false)]
        public string PurposeCode { get; set; }

        public int CountAdult { get; set; }
        public int CountChild { get; set; }

        public string Category { get; set; }
        [Browsable(false)]
        public string CategoryCode { get; set; }

        public string Receipt { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PassportEndDate { get; set; }

        public string Status { get; set; }
        [Browsable(false)]
        public string StatusCode { get; set; }
        
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }
        public string ArrivalDt { get; set; }
        public string Nationality { get; set; }
        [Browsable(false)]
        public int Priority { get; set; }

        public string RedLine { get; set; }
        [Browsable(false)]
        [XmlIgnoreAttribute]
        public DateTime RedLineDt {
            get
            {
                return DateTime.ParseExact(RedLine, Const.DateFormat, CultureInfo.InvariantCulture);
            }
        }

        public static bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPassword(string pass)
        {
            return pass.Length >= 8;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public static void Save(BindingList<VisaTask> tasks)
        {
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\data.xml", FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(BindingList<VisaTask>));
                xs.Serialize(fs, tasks);
            }
        }

        public static BindingList<VisaTask> DeSerialize()
        {
            BindingList<VisaTask> tasks = new BindingList<VisaTask>();
            if (File.Exists(Environment.CurrentDirectory + "\\data.xml"))
            {
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\data.xml", FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(BindingList<VisaTask>));
                    tasks = (BindingList<VisaTask>) xs.Deserialize(fs);
                }
            }
            return tasks;
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("Крайняя дата подачи заявки: " + RedLine);
            sb.AppendLine("");
            sb.AppendLine("Город: " + City);
            sb.AppendLine("Мета візиту: " + Purpose);
            sb.AppendLine("Кількість заявників: " + CountAdult + " К-сть дітей "+CountChild);
            sb.AppendLine("Візова категорія: " + Category);
            sb.AppendLine("Номер квитанції: " + Receipt);
            sb.AppendLine("Email: " + Email);
            sb.AppendLine("Пароль: " + Password);
            return sb.ToString();
        }
    }

    public class VisaComparer : IComparer<VisaTask>
    {
        public int Compare(VisaTask x, VisaTask y)
        {
            if (x.RedLineDt > y.RedLineDt)
                return 1;
            if (x.RedLineDt < y.RedLineDt)
                return -1;
            if (x.Priority > y.Priority)
                return 1;
            if (x.Priority < y.Priority)
                return -1;
            return 0;
        }
    }
}
