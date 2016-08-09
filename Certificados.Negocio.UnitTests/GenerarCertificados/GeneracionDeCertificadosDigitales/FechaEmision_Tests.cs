using System;
using Certificados.Negocio.GenerarCertificados;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Certificados.Negocio.UnitTests.GenerarCertificados
{
    [TestClass]
    public class FechaEmision_Tests: EscenariosDeCertificados
    {
        private CertificadoDigital elCertificado;
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod]
        public void FechaEmision_UnaFechaActual_LaMismaFechaDeEmision()
        {
            elResultadoEsperado = new DateTime(2016, 10, 11);

            elCertificado = ObtengaUnCertificadoNacionalDeAutenticacion();
            elResultadoObtenido = elCertificado.FechaDeEmision;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}