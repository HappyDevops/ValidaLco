using System.Configuration;

namespace ValidaLco.Negocios.Config
{
    public static class UtilsConfigSections
    {
        public static IConfiguracionKit ObtenConfiguracionKit()
        {
            return ConfigurationManager.GetSection("ConfiguracionKit") as ConfiguracionEntorno.ConfiguracionKit;
        }
    }
}
