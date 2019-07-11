using System.Configuration;
using ValidaLco.Negocios.Entidades.Emisores;
using ValidaLco.Negocios.Entidades.Integradores;

namespace ValidaLco.Negocios.Config.ConfiguracionEntorno
{
    public class ConfiguracionConsulta :  ConfigurationElement, IConfiguracionConsultRfc
    {
        /// <inheritdoc />
        TokenIntegrador IConfiguracionConsultRfc.UsuarioIntegrador => ObtenIntegrador();

        private TokenIntegrador ObtenIntegrador()
        {
            return new TokenIntegrador()
            {
                Usuario = Usuario,
                Contraseña = Contraseña
            };
        }

        /// <inheritdoc />
        RFC IConfiguracionConsultRfc.Emisor => RfcEmisor;

        [ConfigurationProperty("Usuario", IsRequired = true, DefaultValue = "")]
        public string Usuario
        {
            get => this["Usuario"]?.ToString();
            set => this["Usuario"] = value;
        }

        [ConfigurationProperty("Contraseña", IsRequired = false, DefaultValue = null)]
        public string Contraseña
        {
            get => this["Contraseña"]?.ToString();
            set => this["Contraseña"] = value;
        }

        [ConfigurationProperty("RfcEmisor", IsRequired = true, DefaultValue = "AAA010101AAA")]
        public string RfcEmisor
        {
            get => this["RfcEmisor"]?.ToString();
            set => this["RfcEmisor"] = value;
        }
    }
}
