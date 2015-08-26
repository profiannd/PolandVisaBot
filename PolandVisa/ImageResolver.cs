using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.Text;
using PolandVisaAuto;
using pvhelper;

namespace PolandVisaMonitor
{
    public class ImageResolver
    {
        uint   port;
        string host;
        string name;
        string passw;
        double balance;
        uint load;
        int ret;
        uint p_pict_to;
        uint p_pict_type;
        uint major_id;
        uint minor_id;
        string answer_captcha;
        private Dictionary<WebProxy, NetworkCredential> _proxyUsers = new Dictionary<WebProxy, NetworkCredential>();
        private Dictionary<WebProxy, RegCount> _proxyRegCounts = new Dictionary<WebProxy, RegCount>();

        public event Action<bool> ChangeUseProxy; 

        private static  ImageResolver _imageResolver = null;
        private ImageResolver()
        {
            port = uint.Parse(ConfigurationManager.AppSettings[Const.PORT]);
            host = ConfigurationManager.AppSettings[Const.HOST];
            name = ConfigurationManager.AppSettings[Const.NAME];
            passw = ConfigurationManager.AppSettings[Const.PASSW];
            AutoResolveImage = bool.Parse(ConfigurationManager.AppSettings[Const.AUTORESOLVE]);
//            UseProxy = bool.Parse(ConfigurationManager.AppSettings[Const.USEPROXY]);
//            AllowReg = int.Parse(ConfigurationManager.AppSettings[Const.ALLOWREG]);
//            ParseRegCounts(ConfigurationManager.AppSettings[Const.REGCOUNTS]);
//            ParseProxies(ConfigurationManager.AppSettings[Const.PROXYSERVERS]);
        }
        
        public static ImageResolver Instance
        {
            get
            {
                if(_imageResolver == null)
                    _imageResolver = new ImageResolver();
                return _imageResolver;
            }
        }

        public string GetBalance()
        {
            balance = 0;
            ret = DecaptcherLib.Decaptcher.Balance(host, port, name, passw, out balance);
            if(ret == 0)
                return Math.Round(balance, 3).ToString();
            return ret.ToString();
        }

        public string RecognizePictureGetString(byte[] buffer)
        {
            answer_captcha = string.Empty;
            ret = DecaptcherLib.Decaptcher.RecognizePicture(host, port, name, passw, buffer, out p_pict_to, out p_pict_type, out answer_captcha, out major_id, out minor_id);
            if (ret == 0)
                return answer_captcha;
            return null;
        }

        public void SystemDecaptcherLoad()
        {
            if(!AutoResolveImage)
                return;
            ret = DecaptcherLib.Decaptcher.SystemDecaptcherLoad(host, port, name, passw, out load);
        }

        public bool AutoResolveImage { get; set; }

        public bool UseProxy
        {
            get { return _useProxy; }
            set
            {
                _useProxy = value;
                if (ChangeUseProxy != null)
                    ChangeUseProxy(_useProxy);
            }
        }

        public int AllowReg { get; set; }
        public List<RegCount> RegCounts { get; set; }
        public string Host 
        {
            get { return host; }
            set { host = value; }
        }

        public void SaveCurrentProxyList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (WebProxy webProxy in WebProxies)
            {
                sb.Append(webProxy.Address.Host);
                sb.Append(":");
                sb.Append(webProxy.Address.Port);
                sb.Append(":");
                sb.Append(ProxyUsers[webProxy].UserName);
                sb.Append(":");
                sb.Append(ProxyUsers[webProxy].Password);
                sb.Append(";");
            }
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[Const.PROXYSERVERS].Value = sb.ToString();
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
        public void SaveProxyRegList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (RegCount rc in ProxyRegCounts.Values)
            {
                if(rc == null)
                    continue;
                sb.Append(rc.CountRegistrations);
                sb.Append("|");
                sb.Append(rc.RegDate.ToString(Const.DateFormat, CultureInfo.InvariantCulture));
                sb.Append("|");
                sb.Append(rc.Address);
                sb.Append(";");
            }
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[Const.REGCOUNTS].Value = sb.ToString();
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void ParseRegCounts(string str)
        {
            RegCounts = new List<RegCount>();
            if (str != null)
            {
                var list = str.Split(';');
                foreach (string s in list)
                {
                    var prox = s.Split('|');
                    if (prox.Length == 3)
                    {
                        var rc = new RegCount()
                        {
                            CountRegistrations = int.Parse(prox[0]),
                            RegDate = DateTime.ParseExact(prox[1], Const.DateFormat, CultureInfo.InvariantCulture),
                            Address = prox[2]
                        };
                        if (rc.RegDate.ToString(Const.DateFormat, CultureInfo.InvariantCulture) == DateTime.Now.ToString(Const.DateFormat, CultureInfo.InvariantCulture))
                            RegCounts.Add(rc);
                    }
                }
            }
        }
        private void ParseProxies(string str)
        {
            ProxyUsers = new Dictionary<WebProxy, NetworkCredential>();
            WebProxies = new Queue<WebProxy>();
            var list = str.Split(';');
            foreach (string s in list)
            {
                var prox = s.Split(':');
                if (prox.Length == 4)
                {
                    try
                    {
                        WebProxy proxy = new WebProxy(prox[0], int.Parse(prox[1]));
                        //Set credentials
                        var credentials = new NetworkCredential(prox[2], prox[3]);
                        proxy.Credentials = credentials;
                        ProxyUsers.Add(proxy, credentials);
                        //Set proxy
                        //WebProxy proxy = new WebProxy(proxyURI, true, null, credentials );
                        // WebProxy proxy = new WebProxy(prox[0], int.Parse(prox[1]));
                        WebProxies.Enqueue(proxy);
                        RegCount rcTofind = null;
                        foreach (var rc in RegCounts)
                        {
                            if (rc.Address == proxy.Address.ToString())
                            {
                                rcTofind = rc;
                                break;
                            }
                        }
                        _proxyRegCounts.Add(proxy, rcTofind);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            if (WebProxies.Count > 0)
                CurrentWebProxy = WebProxies.Peek();
        }

        private int _preventDeadLock = 0;
        private bool _useProxy;

        public void SelectNextProxy()
        {
            if (_preventDeadLock == WebProxies.Count + 1)
            {
                CurrentWebProxy = null;
                UseProxy = false;
                _preventDeadLock = 0;
                return;
            }

            WebProxies.Enqueue(WebProxies.Dequeue());
            WebProxy webProxy = WebProxies.Peek();
            RegCount rc = ProxyRegCounts[webProxy];
            if (rc == null || rc.CountRegistrations < AllowReg)
            {
                CurrentWebProxy = webProxy;
                SaveCurrentProxyList();
                _preventDeadLock = 0;
            }
            else
            {
                _preventDeadLock++;
                SelectNextProxy();
            }
        }

        public Queue<WebProxy> WebProxies { get; set; }
        public WebProxy CurrentWebProxy { get; set; }

        public WebProxy GetCorrectCurrentWebProxy
        {
            get
            {
                if (CurrentWebProxy == null)
                    SelectNextProxy();
                if (CurrentWebProxy == null)
                    return null;
                if (_proxyRegCounts.ContainsKey(CurrentWebProxy))
                {
                    var rc = _proxyRegCounts[CurrentWebProxy];
                    if (rc != null && rc.CountRegistrations >= AllowReg)
                    {
                        SelectNextProxy();
                    }
                }
                return CurrentWebProxy;
            }
        }

        public string CurrentWebProxyRegCount
        {
            get
            {
                var rc = _proxyRegCounts[CurrentWebProxy];
                if (rc == null)
                    return DateToString(0);
                return DateToString(rc.CountRegistrations);
            }
        }

        private string DateToString(int val)
        {
            return string.Format("Количество регистраций на {0} - {1} ",DateTime.Now.ToString(Const.DateFormat, CultureInfo.InvariantCulture), val.ToString());
        }

        public Dictionary<WebProxy, NetworkCredential> ProxyUsers
        {
            get { return _proxyUsers; }
            set { _proxyUsers = value; }
        }
        public Dictionary<WebProxy, RegCount> ProxyRegCounts
        {
            get { return _proxyRegCounts; }
            set { _proxyRegCounts = value; }
        }

        public bool ChekOnLimitRegistraions
        {
            get
            {
                try
                {
                    var rc = _proxyRegCounts[CurrentWebProxy];
                    if (rc == null)
                    {
                        rc = new RegCount()
                        {
                            Address = CurrentWebProxy.Address.ToString(),
                            RegDate = DateTime.Now,
                            CountRegistrations = 1
                        };
                        _proxyRegCounts[CurrentWebProxy] = rc;
                        return false;
                    }
                    rc.CountRegistrations++;
                    return rc.CountRegistrations >= AllowReg;
                }
                finally
                {
                    SaveProxyRegList();
                }
            }
        }
    }
}
