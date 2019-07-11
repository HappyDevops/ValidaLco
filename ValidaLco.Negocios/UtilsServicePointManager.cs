using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace ValidaLco.Negocios
{
    public static class UtilsServicePointManager
    {
        [DebuggerStepThrough]
        public static void AceptaErroresSsl()
        {
            ServicePointManager.ServerCertificateValidationCallback = Callback;
        }

        [DebuggerStepThrough]
        public static bool Callback(object sender,
            X509Certificate certificate,
            X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }       
    }
}