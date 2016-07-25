using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.Negocio.GenerarCertificados;

namespace Certificados.Negocio.UnitTests.GenerarCertificados.Sujetos_Tests
{
    [TestClass]
    public class ComoTexto_Tests : Escenarios
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_NacionalDeAutenticacion_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=CPF-3034560333";

            InicialiceEscenarioNacionalDeAutenticacion();
            elResultadoObtenido = new Sujeto(elNombre, elPrimerApellido, elSegundoApellido, laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_NacionalDeFirma_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (FIRMA), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=CPF-3034560333";

            InicialiceEscenarioNacionalDeFirma();
            elResultadoObtenido = new Sujeto(elNombre, elPrimerApellido, elSegundoApellido, laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_ExtranjeroDeAutenticacion_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-3034560333";

            InicialiceEscenarioExtranjeroDeAutenticacion();
            elResultadoObtenido = new Sujeto(elNombre, elPrimerApellido, elSegundoApellido, laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_ExtranjeroDeFirma_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (FIRMA), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-3034560333";

            InicialiceEscenarioExtranjeroDeFirma();
            elResultadoObtenido = new Sujeto(elNombre, elPrimerApellido, elSegundoApellido, laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
