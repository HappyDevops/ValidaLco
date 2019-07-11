using System.Configuration;

namespace ValidaLco.Negocios.Config.ConfiguracionEntorno
{
    public class ConfiguracionKit :  ConfigurationSection , IConfiguracionKit
    {
        [ConfigurationProperty("IntegradorPorDefecto")]
        public  ConfiguracionConsulta IntegradorPorDefecto => this["IntegradorPorDefecto"] as  ConfiguracionConsulta;

        [ConfigurationProperty("IntegradorConContraseña")]
        public  ConfiguracionConsulta IntegradorConContraseña => this["IntegradorConContraseña"] as  ConfiguracionConsulta;

        /// <inheritdoc />
        IConfiguracionConsultRfc IConfiguracionKit.IntegradorPorDefecto => IntegradorPorDefecto;

        /// <inheritdoc />
        IConfiguracionConsultRfc IConfiguracionKit.IntegradorConContraseña => IntegradorConContraseña;
    }
}