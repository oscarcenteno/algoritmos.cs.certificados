using Sujetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConPolimorfismo.CN_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionFormateada laInformacion;

        [TestMethod]
        public void ComoTexto_EsDeAutenticacion_PropositoCorrecto()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION)";

            laInformacion = new InformacionNacionalDeAutenticacion();
            laInformacion.Nombre = "MARCELINO";
            laInformacion.PrimerApellido = "NAVARRO";
            laInformacion.SegundoApellido = "QUIROS";
            elResultadoObtenido = new CN(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_EsDeFirma_PropositoCorrecto()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (FIRMA)";

            laInformacion = new InformacionNacionalDeFirma();
            laInformacion.Nombre = "MARCELINO";
            laInformacion.PrimerApellido = "NAVARRO";
            laInformacion.SegundoApellido = "QUIROS";
            elResultadoObtenido = new CN(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}