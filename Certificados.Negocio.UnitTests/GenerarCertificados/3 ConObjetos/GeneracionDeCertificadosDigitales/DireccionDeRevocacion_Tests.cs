using Certificados.Negocio.GenerarCertificados.ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Certificados.Negocio.UnitTests.GenerarCertificados.ConObjetos
{
    [TestClass]

    public class GenereUnCertificadoDigital_Tests : EscenariosDeCertificados
    {
        private CertificadoDigital elCertificado;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void DireccionDeRevocacion_UnaDireccion_LaMisma()
        {
            elResultadoEsperado = "http://direccionderevocacion.com";

            elCertificado = ObtengaUnCertificadoNacionalDeAutenticacion();
            elResultadoObtenido = elCertificado.DireccionDeRevocacion;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
