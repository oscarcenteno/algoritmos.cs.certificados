using Sujetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConPolimorfismo.ApellidosFormateados_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionExtranjeraDeAutenticacion laInformacion;

        [TestMethod]
        public void ComoTexto_NoTieneSegundoApellido_NoHayEspaciosAlFinal()
        {
            elResultadoEsperado = "GODINEZ";

            laInformacion = new InformacionExtranjeraDeAutenticacion();
            laInformacion.PrimerApellido = "Godinez";
            laInformacion.SegundoApellido = "";
            elResultadoObtenido = new ApellidosFormateados(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
