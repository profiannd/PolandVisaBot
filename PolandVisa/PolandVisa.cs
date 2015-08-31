using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using mshtml;
using pvhelper;
using Encoder = System.Text.Encoder;

namespace PolandVisaMonitor
{
    public partial class PolandVisa : Form
    {
        private const string VISA = "Національна Віза";
        private const string RUX = "Місцевий Прикордонний Рух";
        private const string SHEN = "Шенгенська Віза";
        private const string SITIES = "Sities";
        private const string MainInterval = "ReqInterval";
        private const string SubInterval = "SubInterval";
        private const string TypeVisa = "TypeVisa";
        private const string NotifCount = "NotifCount";
        private string _visaType = VISA;
        private string _visaCode = string.Empty;
        private RotEvents _enum = RotEvents.Start;
        private int _currentIndex = 0;
        private int _notificCount = 0;
        private SoundPlayer sp;
        private int notifsett = 1;
        private Dictionary<int, string > _values = new Dictionary<int, string>();
        private List<CityData> _cityData = new List<CityData>();
        private Dictionary<string, string> settingsCities = new Dictionary<string, string>();
        private List<string> settingsVisas = new List<string>() { RUX, VISA, SHEN };
        BindingList<CityDataSet> settingsCitiesList = new BindingList<CityDataSet>();
        List<CityDataSet> _listToMonitor = new List<CityDataSet>();

        [ComImport, InterfaceType((short)1), Guid("3050F669-98B5-11CF-BB82-00AA00BDCE0B")]
        private interface IHTMLElementRenderFixed
        {
            void DrawToDC(IntPtr hdc);
            void SetDocumentPrinter(string bstrPrinterName, IntPtr hdc);
        }

        public PolandVisa()
        {
            InitializeComponent();
            settingsCities = Const.FillConfigCities();
            applyConfig();
            initSound();
        }
        


        private void applyConfig()
        {
            LoadConfig();
            InitTimers();
            startMonitor();
        }

        private void LoadConfig()
        {
            mainTimer.Stop();

            settingsCitiesList.Clear();
            var vals = ConfigurationManager.AppSettings[SITIES].Split(';');
            foreach (string val in vals)
            {
                CityDataSet dc = new CityDataSet();
                var param = val.Split('|');
                if (param.Length > 0 && settingsCities.ContainsKey(param[0]))
                {
                    dc.City = settingsCities[param[0]];
                    dc.CityCode = param[0];
                }
                if(param.Length > 1)
                {
                    try
                    {
                        dc.Date = DateTime.ParseExact(param[1], Const.DateFormat, CultureInfo.InvariantCulture);
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.ToString());
                    }
                }
                if (param.Length > 2)
                    dc.IsSelected = param[2] == "1";
                settingsCitiesList.Add(dc);   
            }

            _listToMonitor.Clear();
            foreach (CityDataSet city in settingsCitiesList)
            {
                if (city.IsSelected)
                    _listToMonitor.Add(city);
            }

            _values.Clear();

            dataGridViewResults.DataSource = null;

            txtIntMain.Text = ConfigurationManager.AppSettings[MainInterval];
            txtInt.Text = ConfigurationManager.AppSettings[SubInterval];

            dataGridViewSettings.DataSource = settingsCitiesList;
            cbxVisas.DataSource = settingsVisas;
            int visa = 1;
            int.TryParse(ConfigurationManager.AppSettings[TypeVisa], out visa);
            cbxVisas.SelectedIndex = visa;
            
            txtNotif.Text = ConfigurationManager.AppSettings[NotifCount];
            int.TryParse(ConfigurationManager.AppSettings[NotifCount], out notifsett);
            _visaType = cbxVisas.SelectedItem.ToString();
            _visaCode = getVisaId(_visaType);
        }

        private void SaveConfig()
        {
            StringBuilder sb = new StringBuilder();
            foreach (CityDataSet cityData in settingsCitiesList)
            {
                sb.Append(cityData.WriteToString).Append(";");
            }
            sb.Remove(sb.Length - 1, 1);
            UpdateSetting(SITIES, sb.ToString());
            UpdateSetting(TypeVisa, cbxVisas.SelectedIndex.ToString());
            UpdateSetting(NotifCount, txtNotif.Text);
            UpdateSetting(MainInterval, txtIntMain.Text);
            UpdateSetting(SubInterval, txtInt.Text);
        }

        private static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void ShowResults()
        {
            _cityData.Clear();
            foreach (KeyValuePair<int, string> pair in _values)
            {
                CityData cd = new CityData();
                cd.City = this.webBrowser1.Document.GetElementById("ctl00_plhMain_cboVAC").Children[pair.Key].InnerText.Replace("Польщі ", "").Replace("Poland ", "");
                cd.Date = ProcessDate(pair.Value);
                _cityData.Add(cd);
            }
            dataGridViewResults.DataSource = null;
            if (dataGridViewResults.Columns.Count == 0)
            {
                this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                    {
                        this.Date,
                        this.City
                    });
            }
            dataGridViewResults.DataSource = _cityData;
            dataGridViewResults.Refresh();
            checkOnNotification();
        }

        private void checkOnNotification()
        {
            foreach (CityDataSet cset in settingsCitiesList    )
            {
                if(cset.IsSelected)
                {
                     CityData cd = getCity(cset.City);
                     if (cd != null && cd.Date != DateTime.MinValue && (cset.Date == DateTime.MinValue || cd.Date < cset.Date))
                    {
                        NotifyUser(cd);
                    }
                }
            }
        }

        private void NotifyUser(CityData cd)
        {
            string mess = cd.getMessage();
            if(!rtbMess.Text.Contains(mess))
            {
                rtbMess.AppendText(mess);
                rtbMess.AppendText("\r\n");
            }
            _notificCount += notifsett;
            timerNotify.Start();
        }

        private void timerNotify_Tick(object sender, EventArgs e)
        {
            if(_notificCount-- == 0)
                timerNotify.Stop();
            playSound();
            FlashWindowEx(this);
        }
        
        private void initSound()
        {
            Assembly assembly;
            assembly = Assembly.GetExecutingAssembly();
            sp = new SoundPlayer(assembly.GetManifestResourceStream("PolandVisaMonitor.WindowsNotify.wav"));
        }

        private void playSound()
        {
            //System.Media.SystemSounds.Exclamation.Play();
            sp.Play(); 
        }

        private string getEngCity(string city)
        {
            switch (city)
            {
                case "Івано-Франківськ" :  return  "Ivano-Frankivsk";
                case "Львів"            :  return  "Lviv";
                case "Тернопіль"        :  return  "Ternopil";
                case "Рівне"            :  return  "Rivne";
                case "Луцьк"            :  return  "Lutsk";
                case "Дніпропетровськ"  :  return  "Dnipropetrovsk";
                case "Харків"           :  return  "Kharkiv";
                case "Київ"             :  return  "Kiev";
                case "Одеса"            :  return  "Odessa";
                case  "Хмельницький"    :  return  "Khmelnitskiy";
                case  "Житомир"         :  return  "Zhytomyr";
                case  "Вінниця"         :  return  "Vinnitsya";
                case  "Донецьк"         :  return  "Donetsk";
                case  "Ужгород"         :  return  "Uzhgorod";
                case  "Чернівці"        :  return  "Chernivtsi";
                case "Луганськ"         :  return  "Lugansk";
            }
            return string.Empty;
        }

        private CityData getCity(string city)
        {
            string cityEng = getEngCity(city);
            foreach (CityData cityData in _cityData)
            {
                if (cityData.City == city || cityData.City == cityEng)
                    return cityData;
            }
            return null;
        }

        private DateTime ProcessDate(string xnya)
        {
            DateTime dt = DateTime.MinValue;
            try
            {
                string[] splitted = xnya.Replace("Найближча доступна дата для реєстрації є ", "").Replace("The next available slot for an appointment is ","").Split(new string[]{".","/"},StringSplitOptions.None);
                string s = string.Format("{0}/{1}/{2}", splitted[0].Length == 1 ? "0" + splitted[0] : splitted[0], Const.GetMonthAsInt(splitted[1]), splitted[2]);
                dt = DateTime.ParseExact(s, Const.DateFormat, CultureInfo.InvariantCulture);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return dt;
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Debug.WriteLine("webBrowser1_DocumentCompleted " + DateTime.Now.ToLongTimeString());
            intTimer.Start();
        }

        private void InitTimers()
        {
            int inter = 1;
            int.TryParse(txtInt.Text, out inter);
            intTimer.Interval = inter * 1000;

            inter = 0;
            int.TryParse(txtIntMain.Text, out inter);

            mainTimer.Interval = inter == 0 ? 1000 : inter * 60 * 1000;
        }

        private void startMonitor()
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(Const.Url);
            rtbMess.Clear();
            _enum = RotEvents.Firsthl;
            intTimer.Stop();
        }

        private void processFirstCombo()
        {
            if (_listToMonitor.Count == 0)
                return;
            this.webBrowser1.Document.GetElementById("ctl00$plhMain$cboVAC").SetAttribute("selectedIndex", _listToMonitor[_currentIndex].CityCode);
            this.webBrowser1.Document.GetElementById("ctl00$plhMain$cboVAC").InvokeMember("onchange");
        }

        private string getVisaId(string visa)
        {
            switch (visa)
            {
                case "Національна Віза":
                    return "235";
                case "Шенгенська Віза":
                    return "229";
            }
            return string.Empty;
        }

        private void processInvoke()
        {
            if (this.webBrowser1.Document.GetElementById("ctl00$plhMain$cboVisaCategory").Children.Count == 0)
            {
                throw new Exception("Visa category is not loaded");
            }
            for (int i = 0; i < this.webBrowser1.Document.GetElementById("ctl00$plhMain$cboVisaCategory").Children.Count; i++)
            {
                HtmlElement child = this.webBrowser1.Document.GetElementById("ctl00$plhMain$cboVisaCategory").Children[i];
                if (child.InnerText == _visaType || child.GetAttribute("value") == getVisaId(_visaType))
                {
                    this.webBrowser1.Document.GetElementById("ctl00$plhMain$cboVisaCategory").SetAttribute("value", getVisaId(_visaType));
                    //this.webBrowser1.Document.GetElementById("ctl00$plhMain$cboVisaCategory").SetAttribute("selectedIndex", i.ToString());
                    break;
                }
            }
            ImageResolver.Instance.SystemDecaptcherLoad();
            decaptcherImage();
            this.webBrowser1.Document.GetElementById("ctl00$plhMain$btnSubmit").InvokeMember("click");
        }

        private void decaptcherImage()
        {
            if (!ImageResolver.Instance.AutoResolveImage)
                return;
            string value = ImageResolver.Instance.RecognizePictureGetString(ImageToByte(getFirstImage()));

            // webBrowser.Document.GetElementById("recaptcha_response_field").SetAttribute("value", value);

            //ctl00$plhMain$MyCaptchaControl1
            HtmlElementCollection elems = webBrowser1.Document.All.GetElementsByName("ctl00$plhMain$MyCaptchaControl1");
            HtmlElement elem = null;
            if (elems != null && elems.Count > 0)
            {
                elem = elems[0];
                elem.SetAttribute("value", value);
            }
        }

        public Bitmap getFirstImage()
        {
            IHTMLDocument2 doc = (IHTMLDocument2)webBrowser1.Document.DomDocument;
            foreach (IHTMLImgElement img in doc.images)
            {
                if (img.readyState == "uninitialized")
                {
                    throw new Exception("Cupture Img is not shown");
                }
                IHTMLElementRenderFixed render = (IHTMLElementRenderFixed)img;
                Bitmap bmp = new Bitmap(img.width, img.height);
                Graphics g = Graphics.FromImage(bmp);
                IntPtr hdc = g.GetHdc();
                render.DrawToDC(hdc);
                g.ReleaseHdc(hdc);
                return bmp;
            }
            return null;
        }
        private byte[] ImageToByte(Image img)
        {
            byte[] byteArray = new byte[0];

            ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);
            // Create an Encoder object based on the GUID
            // for the Quality parameter category.
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one
            // EncoderParameter object in the array.
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, jgpEncoder, myEncoderParameters);//ImageFormat.Jpeg);
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

       private string getData()
       {
          return this.webBrowser1.Document.GetElementById("ctl00_plhMain_lblAvailableDateMsg").InnerText;
       }

       private void IncrementOrFreeze()
       {
           _enum = RotEvents.FirstCombo;

           if (_currentIndex < _listToMonitor.Count-1)
           {
               _currentIndex++;
           }
           else
           {
               _currentIndex = 0;
               intTimer.Stop();
               ShowResults();
               mainTimer.Start();
           }
       }
     
       void timer1_Tick(object sender, System.EventArgs e)
        {
           try
           {

               switch (_enum)
               {
                   case RotEvents.Firsthl:
                       webBrowser1.Document.GetElementById("ctl00_plhMain_lnkChkAppmntAvailability").InvokeMember("click");
                       _enum = RotEvents.FirstCombo;
                       intTimer.Stop();
                       break;
                   case RotEvents.FirstCombo:
                   {
                       if (webBrowser1.Document.GetElementById("ctl00_plhMain_lnkChkAppmntAvailability") != null)
                       {
                           webBrowser1.Document.GetElementById("ctl00_plhMain_lnkChkAppmntAvailability").InvokeMember("click");
                           _enum = RotEvents.FirstCombo;
                           intTimer.Stop();
                           break;
                       }
                       if (this.webBrowser1.Document.GetElementById("ctl00$plhMain$cboVAC") == null)
                       {
                           _enum = RotEvents.FirstCombo;
                           break;
                       }
                       processFirstCombo();
                       _enum = RotEvents.Submit;
                       intTimer.Stop();
                       break;
                   }
                   case RotEvents.Submit:
                   {
//                        if (webBrowser1.Document.GetElementById("ctl00_plhMain_VS") != null &&
//                           webBrowser1.Document.GetElementById("ctl00_plhMain_VS").InnerText.Contains("The text you typed does not match the characters in the image."))
//                        {
//                            _enum = RotEvents.FirstCombo;
//                            break;
//                        }
                       processInvoke();
                       _enum = RotEvents.GetData;
                       intTimer.Stop();
                       break;
                   }
                   case RotEvents.GetData:
                   {
                       int code = int.Parse(_listToMonitor[_currentIndex].CityCode);
                       if (_values.ContainsKey(code))
                           _values[code] = getData();
                       else
                           _values.Add(code, getData());
                       Debug.WriteLine("get data " + DateTime.Now.ToLongTimeString() + " " + _values[code]);
                       _enum = RotEvents.FirstCombo;
                       IncrementOrFreeze();
                       break;
                   }
               }
           }
           catch (Exception)
           {
               _enum = RotEvents.FirstCombo;
               intTimer.Start();
           }

        }

       private void pressOnLink(WebBrowser webBrowser, string text)
        {
            try
            {
                var link = webBrowser.Document.GetElementsByTagName("a")[4];
                if (link.InnerText == text)
                    link.InvokeMember("click");
            }
            catch
            {
                foreach(HtmlElement link in webBrowser.Document.GetElementsByTagName("a"))
                {
                    if (link.InnerText == text)
                        link.InvokeMember("click");
                }
            }
        }

        void timer2_Tick(object sender, System.EventArgs e)
       {
           mainTimer.Stop();
           intTimer.Start();
       }

       private void btnSave_Click(object sender, EventArgs e)
       {
           SaveConfig();
           applyConfig();
       }

        private void cellDateTimePickerValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewSettings.CurrentCell.Value = cellDateTimePicker.Text;
            }
            catch (Exception ex)
            {
               Debug.WriteLine(ex.ToString());
            }
            cellDateTimePicker.Visible = false;
        }

        private void dataGridViewSettings_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context == DataGridViewDataErrorContexts.Commit && dataGridViewSettings.CurrentCell.ColumnIndex != 2)
            {
                try
                {
                    dataGridViewSettings.CurrentRow.Cells[2].Value = cellDateTimePicker.Text;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        private void dataGridViewSettings_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var index = dataGridViewSettings.CurrentCell.ColumnIndex;
            if (index == 2)
            {
                Rectangle tempRect = this.dataGridViewSettings.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                cellDateTimePicker.Location = tempRect.Location;
                cellDateTimePicker.Width = tempRect.Width;
                cellDateTimePicker.ValueChanged -= cellDateTimePickerValueChanged;
                try
                {
                    cellDateTimePicker.Value = DateTime.ParseExact(dataGridViewSettings.CurrentCell.Value.ToString(), Const.DateFormat, CultureInfo.InvariantCulture);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    cellDateTimePicker.Value = DateTime.Now;
                }
                cellDateTimePicker.ValueChanged += cellDateTimePickerValueChanged;

                cellDateTimePicker.Visible = true;
            }
        }


        private void dataGridViewSettings_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewSettings.CurrentCell == null)
                return;
            if (dataGridViewSettings.CurrentCell.ColumnIndex == 0)
            {
                dataGridViewSettings.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewSettings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSettings.CurrentCell == null)
                return;
            if (e.ColumnIndex == 0)
            {
                if (!(bool)dataGridViewSettings.CurrentCell.Value)
                {
                    CityDataSet obj = (CityDataSet)dataGridViewSettings.CurrentRow.DataBoundItem;
                    obj.Date = DateTime.MinValue;
                    cellDateTimePicker.Visible = false;
                    dataGridViewSettings.Refresh();
                }
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #region Flash
        // To support flashing.
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        //Flash both the window caption and taskbar button.
        //This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags. 
        public const UInt32 FLASHW_ALL = 3;

        // Flash continuously until the window comes to the foreground. 
        public const UInt32 FLASHW_TIMERNOFG = 12;
        
        // Do the flashing - this does not involve a raincoat.
        public static bool FlashWindowEx(Form form)
        {
            IntPtr hWnd = form.Handle;
            FLASHWINFO fInfo = new FLASHWINFO();

            fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo));
            fInfo.hwnd = hWnd;
            fInfo.dwFlags = FLASHW_ALL | FLASHW_TIMERNOFG;
            fInfo.uCount = UInt32.MaxValue;
            fInfo.dwTimeout = 0;

            return FlashWindowEx(ref fInfo);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            this.Text += version + "   De-Captcher Balance: " + ImageResolver.Instance.GetBalance() + "$"; ;
        }
    }
}
