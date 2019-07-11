using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidaLco.Negocios.Config;

namespace ValidaLco.UnitTests.Unitarias.Config
{
    [TestClass]
    public class UtilsConfigSectionsPruebas
    {
        [TestMethod]
        [TestCategory("Unitarias")]
        public void ObtenConfiguracionKit_Consulta_ResultadoEsperado()
        {
            var configuracion = UtilsConfigSections.ObtenConfiguracionKit();
        }
    }
}
