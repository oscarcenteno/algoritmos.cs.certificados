using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.Negocio.GenerarCertificados;

namespace Certificados.Negocio.UnitTests.GenerarCertificados
{
    [TestClass]
    public class FechaEmision_Tests: Escenarios
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod]
        public void FechaEmision_UnaFechaActual_LaMismaFechaDeEmision()
        {
            elResultadoEsperado = new DateTime(2016, 10, 11);

            InicialiceEscenarioNacionalDeAutenticacion();
            elResultadoObtenido = elCertificado.FechaDeEmision;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
