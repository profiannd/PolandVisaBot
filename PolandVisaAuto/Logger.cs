using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace PolandVisaAuto
{
    public class Logger
    {
        private volatile static ILog _logger;
        private static readonly bool LogMethodNames;

        static Logger()
        {
            //String cfgFile = AppSettings.GetInstance().ConfigFilePath;

            //log4net can not initialize from <WebAppFolder\Bin, so we copy config to tempFolder and then delete it>
            //string tmpFileName = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), Guid.NewGuid().ToString());
            //File.Copy(cfgFile, tmpFileName);
            /////////////////////////
            GlobalContext.Properties["date"] = DateTime.Now.ToString("yyyy_MM");//_dd__hh_mm");
            GlobalContext.Properties["pid"] = Process.GetCurrentProcess().Id;
            GlobalContext.Properties["fname"] = new FileInfo(Process.GetCurrentProcess().MainModule.FileName).Name;
            //XmlConfigurator.Configure(new FileInfo(tmpFileName));
//            try
//            {
//                string dirpath = new FileInfo(Process.GetCurrentProcess().MainModule.FileName).DirectoryName;
//                string fullPath = string.Empty;
//                if (dirpath != null)
//                {
//                    dirpath = Path.Combine(dirpath, "logs");
//                    fullPath = Path.Combine(dirpath, string.Format("{0}_{1}.log"
//                        , GlobalContext.Properties["fname"]
//                        , GlobalContext.Properties["date"]));
//                }
//                FileInfo fi = new FileInfo(fullPath);
//                if(fi.Exists && fi.Length>5000000)
//                {
//                    string bakFile = Path.Combine(dirpath, string.Format("{0}_{1}.bak.log"
//                        , GlobalContext.Properties["fname"]
//                        , GlobalContext.Properties["date"]));
//                    if (File.Exists(bakFile))
//                        File.Delete(bakFile);
//                    fi.MoveTo(bakFile);
//                }
//            }
//            catch{}

            XmlConfigurator.Configure();
            _logger = LogManager.GetLogger(new FileInfo(Process.GetCurrentProcess().MainModule.FileName).Name);

            //File.Delete(tmpFileName);

            LogMethodNames = true;
        }

        private static string GetSourceClassAndMethodName()
        {
            if (!LogMethodNames)
                return "";
            var stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(2);
            MethodBase methodBase = stackFrame.GetMethod();
            string sourceFunctionName = methodBase.Name;
            if (methodBase.DeclaringType != null)
            {
                string sourceClassName = methodBase.DeclaringType.Name;
                return sourceClassName + "->" + sourceFunctionName + "()->";
            }
            return "";
        }

        public static void Info(string msg)
        {

            _logger.Info(GetSourceClassAndMethodName() + msg);
        }

        public static void Warning(string msg)
        {
            _logger.Warn(msg);
        }

        public static void Error(string msg)
        {
            _logger.Error(GetSourceClassAndMethodName() + msg, null);
        }

        public static void Error(Exception ex)
        {
            _logger.Error(ex.ToString());
        }

        public static void Error(string msg, Exception ex)
        {
            _logger.Error(GetSourceClassAndMethodName() + msg, ex);
        }

        public static void Debug(string msg)
        {
            _logger.Debug(GetSourceClassAndMethodName() + msg);
        }

        public static void Fatal(string msg)
        {
            _logger.Fatal(GetSourceClassAndMethodName() + msg);
            throw new ApplicationException(msg);
        }

        public static void Fatal(string msg, Exception ex)
        {
            _logger.Fatal(GetSourceClassAndMethodName() + msg, ex);
            throw new ApplicationException(msg);
        }
    }

}
