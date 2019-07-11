namespace ValidaLco.Negocios.Config
{
    public interface IConfiguracionKit
    {
        IConfiguracionConsultRfc IntegradorPorDefecto { get; }
        IConfiguracionConsultRfc IntegradorConContraseña { get; }
    }
}