using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace E_Konsulat
{
    public enum KonsulatTaskEntityType
    {
        New = 0,
        Completed = 1
    }

    public class KonsulatTask
    {
        public string LastName { get; set; }
        public string PreviousLastName { get; set; }
        public string FirstName { get; set; }
        public string DobCity { get; set; }
        public string DobCountry { get; set; }
        public string Citizenship { get; set; }
        public string Sex { get; set; }
        public string FamilyState { get; set; }

        public string PassportType { get; set; }
        public string PassportNumber { get; set; }
        public string PassportFromDate { get; set; }
        public string PassportToDate { get; set; }
        public string PassportSource { get; set; }
        public string PassportEnotherInfo { get; set; }

        public DateTime RedLineDt { get; set; }
        public int Priority { get; set; }
        public string City
        {
            get { return "Test"; }
            set { ; }
        }
        public string CityV
        {
            get
            {
                switch (CategoryCode)
                {
                    case "1"://National Visa
                        return "(N)" + City;
                    case "2"://Shengen
                        return "(S)" + City;
                }
                return City;
            }
        }
        public string CategoryCode { get; set; }

        //public string PassportType { get; set; }

        public static void Save(BindingList<KonsulatTask> tasks, KonsulatTaskEntityType type)
        {
            string filemane = getFileName(type);
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + filemane, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(BindingList<KonsulatTask>));
                xs.Serialize(fs, tasks);
            }
        }

        public static BindingList<KonsulatTask> DeSerialize(KonsulatTaskEntityType type)
        {
            string filemane = getFileName(type);
            BindingList<KonsulatTask> tasks = new BindingList<KonsulatTask>();
            if (File.Exists(Environment.CurrentDirectory + filemane))
            {
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + filemane, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(BindingList<KonsulatTask>));
                    tasks = (BindingList<KonsulatTask>)xs.Deserialize(fs);
                }
            }
            return tasks;
        }

        private static string getFileName(KonsulatTaskEntityType type)
        {
            return type == KonsulatTaskEntityType.New ? "\\data.xml" : "\\completedData.xml";
        }

        public string GetInfo()
        {
            return "GetInfoGetInfoGetInfoGetInfo";
        }
    }

    public class KonsulatComparer : IComparer<KonsulatTask>
    {
        public int Compare(KonsulatTask x, KonsulatTask y)
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
