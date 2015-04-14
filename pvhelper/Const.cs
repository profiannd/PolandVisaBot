using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace pvhelper
{
    public enum RotEvents
    {
        Start = 0,
        Firsthl = 1,
        FirstCombo = 2,
        Submit = 3,
        GetData = 4,
        SecondCombo = 5,
        FillReceipt = 6,
        FillEmail = 7,
        Stop = 8,
        FirstCupture = 9,
        SecondCupture = 10,
        ThirdCupture = 11
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FLASHWINFO
    {
        public UInt32 cbSize;
        public IntPtr hwnd;
        public UInt32 dwFlags;
        public UInt32 uCount;
        public UInt32 dwTimeout;
    }


    public static class Const
    {
        static Const ()
        {
            //prepareTranslit();
        }

        public const string url = "https://www.vfsvisaonline.com/poland-ukraine-appointment/(S(ytzs0pjoptifju555d1inlbs))/AppScheduling/AppWelcome.aspx?P=s2x6znRcBRv7WQQK7h4MTjZiPRbOsXKqJzddYBh3qCA%3d";
        public const string DateFormat = "dd/MM/yyyy";

        public const string HOST = "host";
        public const string NAME = "name";
        public const string PASSW = "passw";
        public const string PORT = "port";
        public const string AUTORESOLVE = "autoResolve";
        public const string USEPROXY = "useProxy";
        public const string PROXYSERVERS = "proxyServers";

        public static Dictionary<string, string> SettingsCities = FillConfigCities();
        private static Dictionary<string, string> transliter = new Dictionary<string, string>();
        
        private static void prepareTranslit()
        {
            transliter.Add("а", "a");
            transliter.Add("б", "b");
            transliter.Add("в", "v");
            transliter.Add("г", "g");
            transliter.Add("д", "d");
            transliter.Add("е", "e");
            transliter.Add("ё", "yo");
            transliter.Add("ж", "zh");
            transliter.Add("з", "z");
            transliter.Add("и", "i");
            transliter.Add("й", "j");
            transliter.Add("к", "k");
            transliter.Add("л", "l");
            transliter.Add("м", "m");
            transliter.Add("н", "n");
            transliter.Add("о", "o");
            transliter.Add("п", "p");
            transliter.Add("р", "r");
            transliter.Add("с", "s");
            transliter.Add("т", "t");
            transliter.Add("у", "u");
            transliter.Add("ф", "f");
            transliter.Add("х", "h");
            transliter.Add("ц", "c");
            transliter.Add("ч", "ch");
            transliter.Add("ш", "sh");
            transliter.Add("щ", "sch");
            transliter.Add("ъ", "j");
            transliter.Add("ы", "i");
            transliter.Add("ь", "j");
            transliter.Add("э", "e");
            transliter.Add("ю", "yu");
            transliter.Add("я", "ya");
            transliter.Add("А", "A");
            transliter.Add("Б", "B");
            transliter.Add("В", "V");
            transliter.Add("Г", "G");
            transliter.Add("Д", "D");
            transliter.Add("Е", "E");
            transliter.Add("Ё", "Yo");
            transliter.Add("Ж", "Zh");
            transliter.Add("З", "Z");
            transliter.Add("И", "I");
            transliter.Add("Й", "J");
            transliter.Add("К", "K");
            transliter.Add("Л", "L");
            transliter.Add("М", "M");
            transliter.Add("Н", "N");
            transliter.Add("О", "O");
            transliter.Add("П", "P");
            transliter.Add("Р", "R");
            transliter.Add("С", "S");
            transliter.Add("Т", "T");
            transliter.Add("У", "U");
            transliter.Add("Ф", "F");
            transliter.Add("Х", "H");
            transliter.Add("Ц", "C");
            transliter.Add("Ч", "Ch");
            transliter.Add("Ш", "Sh");
            transliter.Add("Щ", "Sch");
            transliter.Add("Ъ", "J");
            transliter.Add("Ы", "I");
            transliter.Add("Ь", "J");
            transliter.Add("Э", "E");
            transliter.Add("Ю", "Yu");
            transliter.Add("Я", "Ya");
        }

        public static string GetTranslit(string sourceText)
        {
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < sourceText.Length; i++)
            {
                if (transliter.ContainsKey(sourceText[i].ToString()))
                {
                    ans.Append(transliter[sourceText[i].ToString()]);
                }
                else
                {
                    ans.Append(sourceText[i].ToString());
                }
            }
            return ans.ToString();
        }

        public static string CityCodeByCity(string city)
        {
            foreach (KeyValuePair<string, string> keyValuePair in Const.SettingsCities)
            {
                if (keyValuePair.Value == city)
                {
                    return keyValuePair.Key;
                }
            }
            return null;
        }

        public static string GetMonthAsInt(string month)
        {
            switch (month)
            {
                case "Січ": return "01";
                case "Лют": return "02";
                case "Бер": return "03";
                case "Кві": return "04";
                case "Тра": return "05";
                case "Чер": return "06";
                case "Лип": return "07";
                case "Сер": return "08";
                case "Вер": return "09";
                case "Жов": return "10";
                case "Лис": return "11";
                case "Гру": return "12";
            }
            return null;
        }

        public static Dictionary<string, string> FillConfigCities()
        {
            Dictionary<string, string> settingsCities = new Dictionary<string, string>();
            settingsCities.Add("1", "Івано-Франківськ");
            settingsCities.Add("2", "Львів");
            settingsCities.Add("3", "Тернопіль");
            settingsCities.Add("4", "Рівне");
            settingsCities.Add("5", "Луцьк");
            settingsCities.Add("6", "Дніпропетровськ");
            settingsCities.Add("7", "Харків");
            settingsCities.Add("8", "Київ");
            settingsCities.Add("9", "Одеса");
            settingsCities.Add("10", "Хмельницький");
            settingsCities.Add("11", "Житомир");
            settingsCities.Add("12", "Вінниця");
            settingsCities.Add("13", "Донецьк");
            settingsCities.Add("14", "Ужгород");
            settingsCities.Add("15", "Чернівці");
            settingsCities.Add("16", "Луганськ");
            return settingsCities;
        }

        public static string CategoryCodeByCat(string cat)
        {
            foreach (KeyValuePair<string, string> keyValuePair in Const.GetCategoryType())
            {
                if (keyValuePair.Value == cat)
                {
                    return keyValuePair.Key;
                }
            }
            return null;
        }

        public static Dictionary<string, string > GetCategoryType()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("1", "Національна Віза");//235
            dict.Add("2", "Шенгенська Віза");//229
            return dict;
        }

        public static string PurposeCodeByPurpose(string  purp)
        {
            foreach (KeyValuePair<string, string> keyValuePair in FillPurpose())
            {
                if (keyValuePair.Value == purp)
                {
                    return keyValuePair.Key;
                }
            }
            return null;
        }

        public static Dictionary<string, string> FillPurpose()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("1", "Подача документів");
            dict.Add("2", "Консультація");
            return dict;
        }


        public static string StatusCodeByStatus(string stat)
        {
            foreach (KeyValuePair<string, string> keyValuePair in FillStatus())
            {
                if (keyValuePair.Value == stat)
                {
                    return keyValuePair.Key;
                }
            }
            return null;
        }

        public static Dictionary<string, string> FillStatus()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("1", "Dr.");
            dict.Add("2", "Mr.");
            dict.Add("3", "Mrs.");
            dict.Add("4", "Ms.");
            dict.Add("5", "Mstr.");
            return dict;
        }

        public static Dictionary<string, string> FillNations()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("1", "AFGHANISTAN");
            dict.Add("2", "ALBANIA");
            dict.Add("3", "ALGERIA");
            dict.Add("4", "ANDORRA");
            dict.Add("5", "ANGOLA");
            dict.Add("6", "ANGUILLA");
            dict.Add("7", "ANTIGUA &amp; BARBUDA");
            dict.Add("8", "ARGENTINA");
            dict.Add("9", "ARMENIA");
            dict.Add("10", "ARUBA");
            dict.Add("11", "AUSTRALIA");
            dict.Add("12", "AUSTRIA");
            dict.Add("13", "AZERBAIJAN");
            dict.Add("14", "BAHAMAS");
            dict.Add("15", "BAHRAIN");
            dict.Add("16", "BANGLADESH");
            dict.Add("17", "BARBADOS");
            dict.Add("18", "BELARUS");
            dict.Add("19", "BELGIUM");
            dict.Add("20", "BELIZE");
            dict.Add("21", "BENIN");
            dict.Add("22", "BERMUDA ISLANDS");
            dict.Add("23", "BHUTAN");
            dict.Add("24", "BOLIVIA");
            dict.Add("25", "BOSNIA-HERCEGOVINA");
            dict.Add("26", "BOTSWANA");
            dict.Add("27", "BRAZIL");
            dict.Add("28", "BRUNEI");
            dict.Add("29", "BULGARIA");
            dict.Add("30", "BURKINA FASO");
            dict.Add("31", "BURUNDI");
            dict.Add("32", "CAMBODIA");
            dict.Add("33", "CAMEROON");
            dict.Add("34", "CANADA");
            dict.Add("35", "CAPE VERDE");
            dict.Add("36", "CAYMAN ISLANDS");
            dict.Add("37", "CENTRAL AFRICAN REP.");
            dict.Add("38", "CHAD");
            dict.Add("39", "CHILE");
            dict.Add("40", "CHINA");
            dict.Add("41", "COLOMBIA");
            dict.Add("42", "COMOROS");
            dict.Add("43", "CONGO, DEM. REP.");
            dict.Add("44", "CONGO, REP.");
            dict.Add("45", "COSTA RICA");
            dict.Add("46", "CROATIA");
            dict.Add("47", "CUBA");
            dict.Add("48", "CYPRUS");
            dict.Add("49", "CZECH REPUBLIC");
            dict.Add("50", "DENMARK");
            dict.Add("51", "DJIBOUTI");
            dict.Add("52", "DOMINICA");
            dict.Add("53", "DOMINICAN REPUBLIC");
            dict.Add("54", "EAST TIMOR");
            dict.Add("55", "ECUADOR");
            dict.Add("56", "EGYPT");
            dict.Add("57", "EL SALVADOR");
            dict.Add("58", "EQUATORIAL GUINEA");
            dict.Add("59", "ERITREA");
            dict.Add("60", "ESTONIA");
            dict.Add("61", "ETHIOPIA");
            dict.Add("62", "FEDERATED STATES OF MICRONESIA");
            dict.Add("63", "FEDERATION OF SAINT KITTS,CHRISTOPHER AND NEVIS");
            dict.Add("64", "FIJI");
            dict.Add("65", "FINLAND");
            dict.Add("66", "FRANCE");
            dict.Add("67", "GABON");
            dict.Add("68", "GAMBIA");
            dict.Add("69", "GEORGIA");
            dict.Add("70", "GERMANY");
            dict.Add("71", "GHANA");
            dict.Add("72", "GREECE");
            dict.Add("73", "GRENADA");
            dict.Add("74", "GRENADINES");
            dict.Add("75", "GUATEMALA");
            dict.Add("76", "GUINEA");
            dict.Add("77", "GUINEA-BISSAU");
            dict.Add("78", "GUYANA");
            dict.Add("79", "HAITI");
            dict.Add("80", "HONDURAS");
            dict.Add("81", "HONGKONG AND MACAO");
            dict.Add("82", "HUNGARY");
            dict.Add("83", "ICELAND");
            dict.Add("84", "INDIA");
            dict.Add("85", "INDONESIA");
            dict.Add("86", "IRAN");
            dict.Add("87", "IRAQ");
            dict.Add("88", "IRELAND");
            dict.Add("89", "ISRAEL");
            dict.Add("90", "ITALY");
            dict.Add("91", "IVORY COAST");
            dict.Add("92", "JAMAICA");
            dict.Add("93", "JAPAN");
            dict.Add("94", "JORDAN");
            dict.Add("95", "KAZAKSTAN");
            dict.Add("96", "KENYA");
            dict.Add("97", "KIRIBATI");
            dict.Add("98", "KOREA (NORTH-)");
            dict.Add("99", "KUWAIT");
            dict.Add("100", "KYRGYSTAN");
            dict.Add("101", "LAOS");
            dict.Add("102", "LATVIA");
            dict.Add("103", "LEBANON");
            dict.Add("104", "LESOTHO");
            dict.Add("105", "LIBERIA");
            dict.Add("106", "LIBYA");
            dict.Add("107", "LIECHTENSTEIN");
            dict.Add("108", "LITHUANIA");
            dict.Add("109", "LUXEMBOURG");
            dict.Add("110", "MACAU");
            dict.Add("111", "MACEDONIA");
            dict.Add("112", "MADAGASCAR");
            dict.Add("113", "MALAWI");
            dict.Add("114", "MALAYSIA");
            dict.Add("115", "MALDIVES");
            dict.Add("116", "MALI");
            dict.Add("117", "MALTA");
            dict.Add("118", "MARSHALL ISLANDS");
            dict.Add("119", "MAURITANIA");
            dict.Add("120", "MAURITIUS");
            dict.Add("121", "MEXICO");
            dict.Add("122", "MICRONESIA");
            dict.Add("123", "MOLDAVIA");
            dict.Add("124", "MOLDOVA");
            dict.Add("125", "MONACO");
            dict.Add("126", "MONGOLIA");
            dict.Add("127", "MONTENEGRO");
            dict.Add("128", "MONTSERRAT");
            dict.Add("129", "MOROCCO");
            dict.Add("130", "MOZAMBIQUE");
            dict.Add("131", "MYANMAR (BURMA)");
            dict.Add("132", "NA");
            dict.Add("133", "NAMIBIA");
            dict.Add("134", "NAURU");
            dict.Add("135", "NEPAL");
            dict.Add("136", "NETHERLANDS");
            dict.Add("137", "NETHERLANDS ANTILLES");
            dict.Add("138", "NEW ZEALAND");
            dict.Add("139", "NICARAGUA");
            dict.Add("140", "NIGER");
            dict.Add("141", "NIGERIA");
            dict.Add("142", "NON-RUSSIAN");
            dict.Add("143", "NORWAY");
            dict.Add("144", "NOTHERN MARIANA ISLANDS");
            dict.Add("145", "OMAN");
            dict.Add("146", "OTHERS");
            dict.Add("147", "PAKISTAN");
            dict.Add("148", "PALAU ISLANDS");
            dict.Add("149", "PALESTINE");
            dict.Add("150", "PANAMA");
            dict.Add("151", "PAPUA NEW GUINEA");
            dict.Add("152", "PARAGUAY");
            dict.Add("153", "PERU");
            dict.Add("154", "PHILIPPINES");
            dict.Add("155", "POLAND");
            dict.Add("156", "PORTUGAL");
            dict.Add("157", "QATAR");
            dict.Add("158", "REPUBLIC DE COTE DIVOIRE");
            dict.Add("159", "REPUBLIC OF BURUNDI");
            dict.Add("160", "REPUBLIC OF CONGO");
            dict.Add("161", "REPUBLIC OF CROATIA");
            dict.Add("162", "REPUBLIC OF KIRIBATI");
            dict.Add("163", "REPUBLIC OF KOREA");
            dict.Add("164", "REPUBLIC OF KOSOVO");
            dict.Add("165", "REPUBLIC OF MACEDONIA");
            dict.Add("166", "REPUBLIC OF PALAU");
            dict.Add("167", "REPUBLIC OF SLOVENIA");
            dict.Add("168", "REPUBLIC OF THE MARSHALL ISLANDS");
            dict.Add("169", "REUNION ISLANDS");
            dict.Add("170", "ROM");
            dict.Add("171", "ROMANIA");
            dict.Add("174", "RUSSIAN FEDERATION");
            dict.Add("175", "RWANDA");
            dict.Add("176", "SAINT LUCIA");
            dict.Add("177", "SAMOA");
            dict.Add("178", "SAN MARINO");
            dict.Add("179", "SAO TOMÉ &amp; PRINCIPE");
            dict.Add("180", "SAUDI ARABIA");
            dict.Add("181", "SENEGAL");
            dict.Add("182", "SERBIA");
            dict.Add("183", "SEYCHELLES");
            dict.Add("184", "SIERRA LEONE");
            dict.Add("185", "SINGAPORE");
            dict.Add("186", "SLOVAK REPUBLIC");
            dict.Add("187", "SLOVENIA");
            dict.Add("188", "SOLOMON ISLANDS");
            dict.Add("189", "SOMALIA");
            dict.Add("190", "SOUTH AFRICA");
            dict.Add("191", "SPAIN");
            dict.Add("192", "SRI LANKA");
            dict.Add("193", "ST. KITTS &amp; NEVIS");
            dict.Add("194", "ST. LUCIA");
            dict.Add("195", "ST. VINCENT &amp; THE");
            dict.Add("196", "STATE OF ERITREA");
            dict.Add("197", "SUDAN");
            dict.Add("198", "SURINAM");
            dict.Add("199", "SWAZILAND");
            dict.Add("200", "SWEDEN");
            dict.Add("201", "SWITZERLAND");
            dict.Add("202", "SYRIA");
            dict.Add("203", "TAIWAN");
            dict.Add("204", "TAJIKISTAN");
            dict.Add("205", "TANZANIA");
            dict.Add("206", "THAILAND");
            dict.Add("207", "THE BAHAMAS");
            dict.Add("208", "THE PHILIPPINES");
            dict.Add("209", "TIBET");
            dict.Add("210", "TOGO");
            dict.Add("211", "TONGA");
            dict.Add("212", "TRINIDAD &amp; TOBAGO");
            dict.Add("213", "TUNISIA");
            dict.Add("214", "TURKEY");
            dict.Add("215", "TURKMENISTAN");
            dict.Add("217", "TUVALU");
            dict.Add("218", "UGANDA");
            dict.Add("219", "UKRAINE");
            dict.Add("216", "Ukrainians");
            dict.Add("220", "UN NATION");
            dict.Add("221", "UN OFFICIAL");
            dict.Add("222", "UNITED ARAB EMIRATES");
            dict.Add("223", "UNITED KINGDOM");
            dict.Add("224", "UNITED NATIONS ORGANIZATION");
            dict.Add("225", "UNITED STATES OF AMERICA");
            dict.Add("226", "URUGUAY");
            dict.Add("227", "UZBEKISTAN");
            dict.Add("228", "VANUATU");
            dict.Add("229", "VATICAN CITY (HOLY SEE)");
            dict.Add("230", "VENEZUELA");
            dict.Add("231", "VIETNAM");
            dict.Add("232", "YEMEN");
            dict.Add("233", "YUGOSLAVIA");
            dict.Add("234", "ZAMBIA");
            dict.Add("235", "ZIMBABWE");
            return dict;
        }

        public static List<string> GetListPriority()
        {
            List<string> priors = new List<string>();
            priors.Add("Низкий");
            priors.Add("Средний");
            priors.Add("Высокий");
            return priors;
        }

        public static List<string> GetListFromDict(Dictionary<string, string> dict)
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> keyValuePair in dict)
            {
                list.Add(keyValuePair.Value);
            }
            return list;
        }
    }
}
