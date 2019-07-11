using System;
using log4net;

namespace ValidaLco.Negocios.Excepciones
{
    public  static class Logger
    {
        public static void Configura()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void Log(string message)
        {
            var logger = LogManager.GetLogger("root");
            logger.Debug(message);
        }
        
        public static void Log(string message, Exception ex)
        {
            var logger = LogManager.GetLogger("root");
            logger.Debug(message, ex);
        }

    }
}
