using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidaLco.Negocios;
using ValidaLco.Negocios.Config;
using ValidaLco.Negocios.Connected_Services.Cliente;
using ValidaLco.Negocios.Entidades.Emisores;
using ValidaLco.Negocios.Entidades.Integradores;

namespace ValidaLco.UnitTests.Integracion
{
    [TestClass]
    public class ValidaLcoPruebas_IntegradorConContraseña
    {
        private static ValidaLCOSoapClient ObtenInstanciaCliente()
        {
            return new ValidaLCOSoapClient();
            
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_UsuarioIntegradorNulo_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(null, emisor.ValorLimpio, RFC.Profact);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(20012, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_UsuarioIntegradorVacio_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(string.Empty, emisor.ValorLimpio, RFC.Profact);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(20012, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_UsuarioIntegradorSoloEspacios_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc("    ", emisor.ValorLimpio, RFC.Profact);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(20012, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_UsuarioIntegradorNoExiste_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc("noExiste", emisor.ValorLimpio, RFC.Profact);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(21, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_UsuarioIntegradorCorrecto_ResultadoCorrecto()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, RFC.Profact);

            Assert.IsTrue(resultado.Correcto);
            Assert.AreEqual(0, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_RfcConsultaGenericoNacional_ResultadoCorrecto()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, RFC.GenericoNacional);

            Assert.IsFalse(resultado.Correcto);
            Assert.IsTrue(resultado.EsRfcGenericoNacional);
            Assert.AreEqual(0, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_RfcConsultaGenericoExtranjero_ResultadoCorrecto()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, RFC.GenericoExtranjero);

            Assert.IsFalse(resultado.Correcto);
            Assert.IsTrue(resultado.EsRfcGenericoExtranjero);
            Assert.AreEqual(0, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_RfcConsultaMinusculas_ResultadoCorrecto()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, RFC.Profact.Valor.ToLower());

            Assert.IsTrue(resultado.Correcto);
            Assert.AreEqual(0, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_RfcConsultaConEspacios_ResultadoCorrecto()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, $"   {RFC.Profact.Valor}   ");

            Assert.IsTrue(resultado.Correcto);
            Assert.AreEqual(0, resultado.Codigo);
        }


        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_EmisorEnMinusculas_ResultadoCorrecto()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.Valor.ToLower(), RFC.Profact);

            Assert.IsTrue(resultado.Correcto);
            Assert.AreEqual(0, resultado.Codigo);
        }


        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_EmisorConEspacios_ResultadoCorrecto()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, $"    {emisor.Valor} ", RFC.Profact);

            Assert.IsTrue(resultado.Correcto);
            Assert.AreEqual(0, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_RfcConsultaNulo_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, null);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(20017, resultado.Codigo);
        }


        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_RfcConsultaVacio_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, string.Empty);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(20017, resultado.Codigo);
        }  
        
        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_RfcConsultaInvalido_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, "invalido");

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(20017, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_RfcConsultaSinHomoclave_ResultadoEsperado()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, "SANK890223");

            Assert.IsFalse(resultado.Correcto);
            Assert.IsFalse(resultado.RegistradoEnElSat);
            Assert.AreEqual(0, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_RfcConsultaNoExiste_ResultadoEsperado()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
            var emisor = ObtenEmisorPorDefecto();

            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, emisor.ValorLimpio, "CCC010101CCC");

            Assert.IsFalse(resultado.Correcto);
            Assert.IsFalse(resultado.RegistradoEnElSat);
            Assert.AreEqual(0, resultado.Codigo);
        }


        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_EmisorNulo_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
         
            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, null, RFC.Profact);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(20004, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_EmisorVacio_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
         
            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, null, RFC.Profact);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(20004, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_EmisorInvalido_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
         
            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, "invalido", RFC.Profact);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(20004, resultado.Codigo);
        }

        [TestMethod]
        [TestCategory("Integración")]
        [TestCategory("ValidaLco")]
        public void ConsultaRfc_EmisorNoPerteneceAlIntegrador_DebeRetornarError()
        {
            var cliente = ObtenInstanciaCliente();
            var integrador = ObtenIntegradorPorDefecto();
         
            UtilsServicePointManager.AceptaErroresSsl();
            var resultado = cliente.ConsultaRfc(integrador.Valor, "BBB010101BBB", RFC.Profact);

            Assert.IsFalse(resultado.Correcto);
            Assert.AreEqual(16, resultado.Codigo);
        }


        private TokenIntegrador ObtenIntegradorPorDefecto()
        {
            var configuracionTesting = UtilsConfigSections.ObtenConfiguracionKit();
            return configuracionTesting.IntegradorConContraseña.UsuarioIntegrador;
        }

        private RFC ObtenEmisorPorDefecto()
        {
            var configuracionTesting = UtilsConfigSections.ObtenConfiguracionKit();
            return configuracionTesting.IntegradorConContraseña.Emisor;
        }
    }
}
