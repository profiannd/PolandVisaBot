using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using pvhelper;

namespace PolandVisaAuto
{
    public class ImageResolver
    {
        uint   port;
        string host;
        string name;
        string passw;
        double balance;
        int ret;

        private static  ImageResolver _imageResolver = null;
        private ImageResolver()
        {
            port = uint.Parse(ConfigurationManager.AppSettings[Const.PORT]);
            host = ConfigurationManager.AppSettings[Const.HOST];
            name = ConfigurationManager.AppSettings[Const.NAME];
            passw = ConfigurationManager.AppSettings[Const.PASSW];
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
                return balance.ToString();
            return ret.ToString();
        }
    }
}
