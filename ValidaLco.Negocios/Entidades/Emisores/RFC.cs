using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ValidaLco.Negocios.Entidades.Emisores
{
    /// <summary>
    ///     Estructura que representa un Registro Federal de contribuyentes.
    /// </summary>
    [DebuggerDisplay("RFC={Valor},EsValido={EsValido}")]
    public struct RFC
    {
        public static RFC GenericoNacional => RFC_GENERICO;
        public static RFC GenericoExtranjero => RFC_GENERICO_EXTRANJERO;
        public static RFC Pruebas => RFC_PRUEBAS;
        public static RFC Profact => RFC_PROFACT;

        public bool Equals(RFC other)
        {
            return string.Equals(_valor, other._valor);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is RFC rfc && Equals(rfc);
        }

        public override int GetHashCode()
        {
            return _valor?.GetHashCode() ?? 0;
        }


        public override string ToString()
        {
            return ValorLimpio;
        }

        private const string RFC_PRUEBAS = "AAA010101AAA";
        private const string RFC_PROFACT = "PFE140312IW8";
        private const string RFC_GENERICO = "XAXX010101000";
        private const string RFC_GENERICO_EXTRANJERO = "XEXX010101000";
        private const string REGEX_RFC = "^([A-Z,Ñ,&]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?)$";
        private string _valor;


        public string ValorLimpio => Valor?.Replace("&AMP;", "&").Replace("Ã‘", "Ñ").Replace("Ã±", "Ñ");

        public string Valor
        {
            get => _valor?.ToUpperInvariant().Trim();
            set => _valor = value?.ToUpperInvariant().Trim();
        }

        public bool EsValido => Valor != null && Regex.IsMatch(ValorLimpio, REGEX_RFC, RegexOptions.Compiled);

        public static implicit operator string(RFC value)
        {
            return value.ValorLimpio?.ToUpper();
        }

        public static implicit operator RFC(string value)
        {
            var rfc = new RFC {Valor = value};
            return rfc;
        }

        public static bool operator ==(RFC rfc1,
            RFC rfc2)
        {
            return rfc1.Valor == rfc2.Valor;
        }

        public static bool operator !=(RFC rfc1,
            RFC rfc2)
        {
            return !(rfc1 == rfc2);
        }
    }
}