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
        [Browsable(false)]
        public string PreviousLastNamePersonal { get; set; }
        public string FirstNamePersonal { get; set; }
        [Browsable(false)]
        public DateTime DobPersonal { get; set; }
        [Browsable(false)]
        public string DobCityPersonal { get; set; }
        [Browsable(false)]
        public string DobCountryPersonal { get; set; }
        [Browsable(false)]
        public string CitizenshipPersonal { get; set; }
        [Browsable(false)]
        public string NationalityPersonal { get; set; }
        [Browsable(false)]
        public bool SexMRadioPersonal { get; set; }
        [Browsable(false)]
        public string FamilyStateRadioPersonal { get; set; }

        //PassportData
        [Browsable(false)]
        public string PassportTypeRadio { get; set; }
        [Browsable(false)]
        public string PassportNumber { get; set; }
        [Browsable(false)]
        public DateTime PassportFromDate { get; set; }
        [Browsable(false)]
        public DateTime PassportToDate { get; set; }
        [Browsable(false)]
        public string PassportSource { get; set; }
        [Browsable(false)]
        public string PassportEnotherInfo { get; set; }


        //ChildData
        [Browsable(false)]
        public string CitizenshipChild { get; set; }
        [Browsable(false)]
        public string FirstNameChild { get; set; }
        [Browsable(false)]
        public string LastNameChild { get; set; }
        [Browsable(false)]
        public string CountryChild { get; set; }
        [Browsable(false)]
        public string StateChild { get; set; }
        [Browsable(false)]
        public string CityChild { get; set; }
        [Browsable(false)]
        public string ZipChild { get; set; }
        [Browsable(false)]
        public string AddressChild{ get; set; }


        //AddressData
        [Browsable(false)]
        public string CountryAddress { get; set; }
        [Browsable(false)]
        public string StateAddress { get; set; }
        [Browsable(false)]
        public string CityAddress { get; set; }
        [Browsable(false)]
        public string ZipAddress { get; set; }
        [Browsable(false)]
        public string AddressAddress { get; set; }
        [Browsable(false)]
        public string EmailAddress { get; set; }
        [Browsable(false)]
        public string PrefixAddress { get; set; }
        [Browsable(false)]
        public string TelNumberAddress { get; set; }


        //BossAddressData
        [Browsable(false)]
        public bool BLRadioBossAddress { get; set; }
        [Browsable(false)]
        public string CountryBossAddress { get; set; }
        [Browsable(false)]
        public string StateBossAddress { get; set; }
        [Browsable(false)]
        public string CityBossAddresss { get; set; }
        [Browsable(false)]
        public string ZipBossAddress { get; set; }
        [Browsable(false)]
        public string AddressBossAddress { get; set; }
        [Browsable(false)]
        public string NameBossAddress { get; set; }
        [Browsable(false)]
        public string EmailBossAddress { get; set; }
        [Browsable(false)]
        public string PrefixBossAddress { get; set; }
        [Browsable(false)]
        public string TelNumberBossAddress { get; set; }
        [Browsable(false)]
        public string FaxBossAddress { get; set; }
        [Browsable(false)]
        public string FaxPrefixBossAddress { get; set; }

        //FingerprintsData
        [Browsable(false)]
        public bool FingYNFingerprints { get; set; }


        //TheseEuCitizenData
        [Browsable(false)]
        public string LastNameEuCitizen { get; set; }
        [Browsable(false)]
        public string NameEuCitizen { get; set; }
        [Browsable(false)]
        public string PassportNumberEuCitizen { get; set; }
        [Browsable(false)]
        public DateTime DobEuCitizen { get; set; }
        [Browsable(false)]
        public string KinEuCitizen { get; set; }


        //TargetData
        [Browsable(false)]
        public bool TourismTarget { get; set; }
        [Browsable(false)]
        public bool DealTarget { get; set; }
        [Browsable(false)]
        public bool FamilyTarget { get; set; }
        [Browsable(false)]
        public bool CultureTarget { get; set; }
        [Browsable(false)]
        public bool SportTarget { get; set; }
        [Browsable(false)]
        public bool OfficialTarget { get; set; }
        [Browsable(false)]
        public bool TreatmentTarget { get; set; }
        [Browsable(false)]
        public bool LearningTarget { get; set; }
        [Browsable(false)]
        public bool OtherTarget { get; set; }
        [Browsable(false)]
        public string TextOtherTarget { get; set; }


        //InformationData
        [Browsable(false)]
        public string DestinationInform { get; set; }
        [Browsable(false)]
        public string NumbDayInform { get; set; }
        [Browsable(false)]
        public string WaiverInform { get; set; }
        [Browsable(false)]
        public DateTime ArrivalInform { get; set; }
        [Browsable(false)]
        public DateTime CheckOutInform { get; set; }
        [Browsable(false)]
        public string EntryStateRadioInform { get; set; }

        //SchengenvisasData
        [Browsable(false)]
        public bool YNVisa { get; set; }
        [Browsable(false)]
        public DateTime From1Visa { get; set; }
        [Browsable(false)]
        public DateTime From2Visa { get; set; }
        [Browsable(false)]
        public DateTime To1Visa { get; set; }
        [Browsable(false)]
        public DateTime To2Visa { get; set; }

        //InfereceivingData
        [Browsable(false)]
        public bool FirmManRadioInferec { get; set; }
        [Browsable(false)]
        public string TitleInferec { get; set; }
        [Browsable(false)]
        public string NameInferec { get; set; }
        [Browsable(false)]
        public string LastNameInferec { get; set; }
        [Browsable(false)]
        public string StateInferec { get; set; }
        [Browsable(false)]
        public string CityInferec { get; set; }
        [Browsable(false)]
        public string PostcodeInferec { get; set; }
        [Browsable(false)]
        public string PrefixInferec { get; set; }
        [Browsable(false)]
        public string TelNumberInferec { get; set; }
        [Browsable(false)]
        public string FaxPrefixInferec { get; set; }
        [Browsable(false)]
        public string FaxInferec { get; set; }
        [Browsable(false)]
        public string AddressInferec { get; set; }
        [Browsable(false)]
        public string HouseNumberInferec { get; set; }
        [Browsable(false)]
        public string ApNumberInferec { get; set; }
        [Browsable(false)]
        public string EmailInferec { get; set; }

        //CountryData
        [Browsable(false)]
        public bool DocumentRadioCountry { get; set; }
        [Browsable(false)]
        public string PassNumber { get; set; }
        [Browsable(false)]
        public DateTime FromCountry { get; set; }

        //PersonalCostsData
        public bool CostRadioPersCost { get; set; }
        [Browsable(false)]
        public bool ReferredPersCost { get; set; }
        [Browsable(false)]
        public bool OtherPersCost { get; set; }
        [Browsable(false)]
        public bool MoneyPersCost { get; set; }
        [Browsable(false)]
        public bool ChecksPersCost { get; set; }
        [Browsable(false)]
        public bool CardPersCost { get; set; }
        [Browsable(false)]
        public bool AllCostsPersCost { get; set; }
        [Browsable(false)]
        public bool OtherCostsPersCost { get; set; }
        [Browsable(false)]
        public bool LocationPersCost { get; set; }
        [Browsable(false)]
        public bool TransportPersCost { get; set; }
        [Browsable(false)]
        public bool InsurancePersCost { get; set; }
        [Browsable(false)]
        public string OthePersCost { get; set; }
        [Browsable(false)]
        public string OtheCostsPersCost { get; set; }
        [Browsable(false)]
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
