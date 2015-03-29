using System;
using System.Configuration;
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
        uint load;
        int ret;
        uint p_pict_to;
        uint p_pict_type;
        uint major_id;
        uint minor_id;
        string answer_captcha;


        private static  ImageResolver _imageResolver = null;
        private ImageResolver()
        {
            port = uint.Parse(ConfigurationManager.AppSettings[Const.PORT]);
            host = ConfigurationManager.AppSettings[Const.HOST];
            name = ConfigurationManager.AppSettings[Const.NAME];
            passw = ConfigurationManager.AppSettings[Const.PASSW];
            AutoResolveImage = bool.Parse(ConfigurationManager.AppSettings[Const.AUTORESOLVE]);
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
        public string Host 
        {
            get { return host; }
            set { host = value; }
        }
    }
}
