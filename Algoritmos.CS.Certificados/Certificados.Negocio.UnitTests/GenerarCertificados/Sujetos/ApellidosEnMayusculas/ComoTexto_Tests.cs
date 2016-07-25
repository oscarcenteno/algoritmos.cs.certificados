using Sujetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.Negocio.GenerarCertificados;

namespace Algoritmos.CS.Sujetos.UnitTests.ConPolimorfismo.ApellidosEnMayusculas_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosDeUnCertificadoDigital laInformacion;

        [TestMethod]
        public void ComoTexto_DosApellidos_UnidosYEnMayuscula()
        {
            elResultadoEsperado = "GODINEZ SANCHEZ";

            laInformacion = new DatosDeUnCertificadoDigital();
            laInformacion.PrimerApellido = "Godinez";
            laInformacion.SegundoApellido = "Sanchez";
            elResultadoObtenido = new ApellidosEnMayusculas(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
