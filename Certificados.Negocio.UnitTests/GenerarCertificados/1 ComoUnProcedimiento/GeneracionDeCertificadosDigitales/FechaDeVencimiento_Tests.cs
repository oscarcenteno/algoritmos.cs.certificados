using System;
using Certificados.Negocio.GenerarCertificados.ComoUnProcedimiento;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Certificados.Negocio.UnitTests.GenerarCertificados.ComoUnProcedimiento
{
    [TestClass]
    public class FechaDeVencimiento_Tests : EscenariosDeCertificados
    {
        private CertificadoDigital elCertificado;
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod]
        public void FechaDeVencimiento_UnaFechaActual_CuatroAñosEnElFuturo()
        {
            elResultadoEsperado = new DateTime(2020, 10, 11);

            elCertificado = ObtengaUnCertificadoNacionalDeAutenticacion();
            elResultadoObtenido = elCertificado.FechaDeVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}