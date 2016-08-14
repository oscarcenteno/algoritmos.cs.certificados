using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Certificados.Negocio.UnitTests.GenerarCertificados.ConPolimorfismo
{
    [TestClass]
    public class Sujeto_Tests : EscenariosDeCertificados
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private CertificadoDigital elCertificado;

        [TestMethod]
        public void Sujeto_NacionalDeAutenticacion_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=CPF-3034560333";

            elCertificado = ObtengaUnCertificadoNacionalDeAutenticacion();
            elResultadoObtenido = elCertificado.Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Sujeto_NacionalDeFirma_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (FIRMA), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=CPF-3034560333";

            elCertificado = ObtengaUnCertificadoNacionalDeFirma();
            elResultadoObtenido = elCertificado.Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Sujeto_ExtranjeroDeAutenticacion_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-3034560333";

            elCertificado = ObtengaUnCertificadoExtranjeroDeAutenticacion();
            elResultadoObtenido = elCertificado.Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Sujeto_ExtranjeroDeFirma_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (FIRMA), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-3034560333";

            elCertificado = ObtengaUnCertificadoExtranjeroDeFirma();
            elResultadoObtenido = elCertificado.Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}