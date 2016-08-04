using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Certificados.Negocio.UnitTests.GenerarCertificados
{
    [TestClass]
    public class FechaDeVencimiento_Tests : Escenarios
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod]
        public void FechaDeVencimiento_UnaFechaActual_CuatroAñosEnElFuturo()
        {
            elResultadoEsperado = new DateTime(2020, 10, 11);

            InicialiceEscenarioNacionalDeAutenticacion();
            elResultadoObtenido = elCertificado.FechaDeVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
