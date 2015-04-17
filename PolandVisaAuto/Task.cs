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
    public enum VisaEntityType
    {
        New = 0,
        Completed = 1
    }

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
        [XmlIgnoreAttribute]
        public string PriorityStr { get { return Const.GetListPriority()[Priority]; } }

        public string RedLine { get; set; }
        [Browsable(false)]
        [XmlIgnoreAttribute]
        public DateTime RedLineDt {
            get
            {
                return DateTime.ParseExact(RedLine, Const.DateFormat, CultureInfo.InvariantCulture);
            }
        }

        public string GreenLine { get; set; }
        [Browsable(false)]
        [XmlIgnoreAttribute]
        public DateTime GreenLineDt
        {
            get
            {
                return DateTime.ParseExact(GreenLine, Const.DateFormat, CultureInfo.InvariantCulture);
            }
        }

        public string RegistrationInfo { get; set; }

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

        public static void Save(BindingList<VisaTask> tasks, VisaEntityType type)
        {
            string filemane = getFileName(type);
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + filemane, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(BindingList<VisaTask>));
                xs.Serialize(fs, tasks);
            }
        }

        public static BindingList<VisaTask> DeSerialize(VisaEntityType type)
        {
            string filemane = getFileName(type);
            BindingList<VisaTask> tasks = new BindingList<VisaTask>();
            if (File.Exists(Environment.CurrentDirectory + filemane))
            {
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + filemane, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(BindingList<VisaTask>));
                    tasks = (BindingList<VisaTask>) xs.Deserialize(fs);
                }
            }
            return tasks;
        }

        private static string getFileName(VisaEntityType type)
        {
            return type == VisaEntityType.New ? "\\data.xml" : "\\completedData.xml";
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name + " " + LastName);
            sb.AppendLine(string.Format("Крайняя дата подачи заявки от {2} до {0}, приоритет {1}",RedLine, PriorityStr, GreenLine));
            sb.AppendLine("");
            sb.AppendLine("Город: " + City);
            sb.AppendLine("Мета візиту: " + Purpose);
            sb.AppendLine(string.Format("Кількість заявників: {0}, К-сть дітей {1}",CountAdult,CountChild));
            sb.AppendLine("Візова категорія: " + Category);
            sb.AppendLine("Номер квитанції: " + Receipt);
            sb.AppendLine("Email: " + Email);
            sb.AppendLine("Пароль: " + Password);
            return sb.ToString();
        }

        public VisaTask Clone()
        {
            VisaTask vt = new VisaTask();
            vt.ArrivalDt = ArrivalDt;
            vt.Category = Category;
            vt.CategoryCode = CategoryCode;
            vt.City = City;
            vt.CityCode = CityCode;
            vt.CountAdult = CountAdult;
            vt.CountChild = CountChild;
            vt.Dob = Dob;
            vt.Email = Email;
            vt.LastName = LastName;
            vt.Name = Name;
            vt.Nationality = Nationality;
            vt.PassportEndDate = PassportEndDate;
            vt.Password = Password;
            vt.Priority = Priority;
            vt.Purpose = Purpose;
            vt.PurposeCode = PurposeCode;
            vt.Receipt = Receipt;
            vt.RedLine = RedLine;
            vt.GreenLine = GreenLine;
            vt.RegistrationInfo = RegistrationInfo;
            vt.Status = Status;
            vt.StatusCode = StatusCode;
            return vt;
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
                return -1;
            if (x.Priority < y.Priority)
                return 1;
            return 0;
        }
    }
}
