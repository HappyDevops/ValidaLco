using System;
using System.Diagnostics;

namespace ValidaLco.Negocios.Entidades.Integradores
{
    /// <summary>
    ///     Estructura que representa un token de integrador.
    /// </summary>
    [DebuggerDisplay("Valor={Valor},EsValido={EsValido}")]
    public struct TokenIntegrador
    {
        public static string Separador => "|";


        public bool Equals(TokenIntegrador other)
        {
            return string.Equals(Usuario, other.Usuario);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is TokenIntegrador token && Equals(token);
        }

        public override int GetHashCode()
        {
            return Usuario?.GetHashCode() ?? 0;
        }


        public override string ToString()
        {
            return Valor;
        }


        public string Valor
        {
            get => $"{Usuario}|{Contraseña}";
            set => ProcesaAsignacionToken(value);
        }

        private void ProcesaAsignacionToken(string value)
        {
            var token = Parse(value);
            Usuario = token.Usuario;
            Contraseña = token.Contraseña;
        }

        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public bool EsValido => ProcesaEsTokenValido();

        private bool ProcesaEsTokenValido()
        {
            return !string.IsNullOrWhiteSpace(Usuario);
        }

        public static implicit operator string(TokenIntegrador value)
        {
            return value.Valor?.ToUpper();
        }

        public static implicit operator TokenIntegrador(string value)
        {
            var token = Parse(value);
            return token;
        }

        public static bool operator ==(TokenIntegrador token1,
            TokenIntegrador token2)
        {
            return token1.Usuario == token2.Usuario;
        }

        public static bool operator !=(TokenIntegrador token1,
            TokenIntegrador token2)
        {
            return !(token1 == token2);
        }

        public static TokenIntegrador Parse(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return new TokenIntegrador();
            }

            var values = s.Split(new[] {Separador}, StringSplitOptions.RemoveEmptyEntries);

            if (values.Length != 1 && values.Length != 2)
            {
                return new TokenIntegrador();
            }

            var token = new TokenIntegrador {Usuario = values[0], Contraseña = values.Length > 1 ? values[1] : null};

            return token;
        }
    }
}