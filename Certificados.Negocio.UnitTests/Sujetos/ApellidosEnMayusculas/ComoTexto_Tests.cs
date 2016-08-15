using Sujetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Algoritmos.CS.Sujetos.UnitTests.ConPolimorfismo.ApellidosEnMayusculas_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionNacionalDeAutenticacion laInformacion;

        [TestMethod]
        public void ComoTexto_DosApellidos_UnidosYEnMayuscula()
        {
            elResultadoEsperado = "GODINEZ SANCHEZ";

            laInformacion = new InformacionNacionalDeAutenticacion();
            laInformacion.PrimerApellido = "Godinez";
            laInformacion.SegundoApellido = "Sanchez";
            elResultadoObtenido = new ApellidosEnMayusculas(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
