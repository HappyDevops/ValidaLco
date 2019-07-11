using ValidaLco.Negocios.Entidades.Emisores;
using ValidaLco.Negocios.Entidades.Integradores;

namespace ValidaLco.Negocios.Config
{
    public interface IConfiguracionConsultRfc
    {
        TokenIntegrador UsuarioIntegrador { get; }
        RFC Emisor { get; }
    }
}
