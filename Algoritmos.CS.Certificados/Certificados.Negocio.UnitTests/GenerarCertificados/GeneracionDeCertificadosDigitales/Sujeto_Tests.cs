using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.Negocio.GenerarCertificados;

namespace Certificados.Negocio.UnitTests.GenerarCertificados
{
    [TestClass]
    public class Sujeto_Tests : Escenarios
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void Sujeto_NacionalDeAutenticacion_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=CPF-3034560333";

            InicialiceEscenarioNacionalDeAutenticacion();
            elResultadoObtenido = elCertificado.Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Sujeto_NacionalDeFirma_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (FIRMA), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=CPF-3034560333";

            InicialiceEscenarioNacionalDeFirma();
            elResultadoObtenido = elCertificado.Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Sujeto_ExtranjeroDeAutenticacion_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-3034560333";

            InicialiceEscenarioExtranjeroDeAutenticacion();
            elResultadoObtenido = elCertificado.Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Sujeto_ExtranjeroDeFirma_SujetoFormateado()
        {
            elResultadoEsperado = "CN=MIGUEL SUAREZ GODINEZ (FIRMA), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-3034560333";

            InicialiceEscenarioExtranjeroDeFirma();
            elResultadoObtenido = elCertificado.Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
