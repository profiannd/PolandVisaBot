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
        //PersonalData
        public string LastNamePersonal { get; set; }
        public string PreviousLastNamePersonal { get; set; }
        public string FirstNamePersonal { get; set; }
        public DateTime DobPersonal { get; set; }
        public string DobCityPersonal { get; set; }
        public string DobCountryPersonal { get; set; }
        public string CitizenshipPersonal { get; set; }
        public string NationalityPersonal { get; set; }
        public bool SexMRadioPersonal { get; set; }
        public string FamilyStateRadioPersonal { get; set; }

        //PassportData
        public string PassportTypeRadio { get; set; }
        public string PassportNumber { get; set; }
        public DateTime PassportFromDate { get; set; }
        public DateTime PassportToDate { get; set; }
        public string PassportSource { get; set; }
        public string PassportEnotherInfo { get; set; }


        //ChildData
        public string CitizenshipChild { get; set; }
        public string FirstNameChild { get; set; }
        public string LastNameChild { get; set; }
        public string CountryChild { get; set; }
        public string StateChild{ get; set; }
        public string CityChild{ get; set; }
        public string ZipChild{ get; set; }
        public string AddressChild{ get; set; }


        //AddressData
        public string CountryAddress { get; set; }
        public string StateAddress { get; set; }
        public string CityAddress { get; set; }
        public string ZipAddress { get; set; }
        public string AddressAddress { get; set; }
        public string EmailAddress { get; set; }
        public string PrefixAddress { get; set; }
        public string TelNumberAddress { get; set; }


        //BossAddressData
        public bool BLRadioBossAddress { get; set; }
        public string CountryBossAddress { get; set; }
        public string StateBossAddress { get; set; }
        public string CityBossAddresss { get; set; }
        public string ZipBossAddress { get; set; }
        public string AddressBossAddress { get; set; }
        public string NameBossAddress { get; set; }
        public string EmailBossAddress { get; set; }
        public string PrefixBossAddress { get; set; }
        public string TelNumberBossAddress { get; set; }
        public string FaxBossAddress { get; set; }
        public string FaxPrefixBossAddress { get; set; }

        //FingerprintsData
        public bool FingYNFingerprints { get; set; }


        //TheseEuCitizenData
        public string LastNameEuCitizen { get; set; }
        public string NameEuCitizen { get; set; }
        public string PassportNumberEuCitizen { get; set; }
        public DateTime DobEuCitizen { get; set; }
        public string KinEuCitizen { get; set; }


        //TargetData
        public bool TourismTarget { get; set; }
        public bool DealTarget { get; set; }
        public bool FamilyTarget { get; set; }
        public bool CultureTarget { get; set; }
        public bool SportTarget { get; set; }
        public bool OfficialTarget { get; set; }
        public bool TreatmentTarget { get; set; }
        public bool LearningTarget { get; set; }
        public bool OtherTarget { get; set; }
        public string TextOtherTarget { get; set; }


        //InformationData
        public string DestinationInform { get; set; }
        public string NumbDayInform { get; set; }
        public string WaiverInform { get; set; }
        public DateTime ArrivalInform { get; set; }
        public DateTime CheckOutInform { get; set; }
        public string EntryStateRadioInform { get; set; }

        //SchengenvisasData
        public bool YNVisa { get; set; }
        public DateTime From1Visa { get; set; }
        public DateTime From2Visa { get; set; }
        public DateTime To1Visa { get; set; }
        public DateTime To2Visa { get; set; }

        //InfereceivingData
        public bool FirmManRadioInferec { get; set; }
        public string TitleInferec { get; set; }
        public string NameInferec { get; set; }
        public string LastNameInferec { get; set; }
        public string StateInferec { get; set; }
        public string CityInferec { get; set; }
        public string PostcodeInferec { get; set; }
        public string PrefixInferec { get; set; }
        public string TelNumberInferec { get; set; }
        public string FaxPrefixInferec { get; set; }
        public string FaxInferec { get; set; }
        public string AddressInferec { get; set; }
        public string HouseNumberInferec { get; set; }
        public string ApNumberInferec { get; set; }
        public string EmailInferec { get; set; }

        //CountryData
        public bool DocumentRadioCountry { get; set; }
        public string PassNumber { get; set; }
        public DateTime FromCountry { get; set; }

        //PersonalCostsData
        public bool CostRadioPersCost { get; set; }
        public bool ReferredPersCost { get; set; }
        public bool OtherPersCost { get; set; }
        public bool MoneyPersCost { get; set; }
        public bool ChecksPersCost { get; set; }
        public bool CardPersCost { get; set; }
        public bool AllCostsPersCost { get; set; }
        public bool OtherCostsPersCost { get; set; }
        public bool LocationPersCost { get; set; }
        public bool TransportPersCost { get; set; }
        public bool InsurancePersCost { get; set; }
        public string OthePersCost { get; set; }
        public string OtheCostsPersCost { get; set; }
        public DateTime DateInsurancePersCost { get; set; }


        #region Services
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
        #endregion
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
