using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace Certificados.Negocio.UnitTests.GenerarEmision.ConInversionDeDependencias.Emision_Tests
{
    [TestClass]
    public class FechaDeGeneracion_Tests
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod]
        public void FechaDeGeneracion_UnaFechaActual_LaMismaEsLaFechaDeGeneracion()
        {
            elResultadoEsperado = new DateTime(2016, 10, 11);

            DatosDeLaEmision losDatos = Substitute.For<DatosDeLaEmision>();
            losDatos.FechaActual.Returns(elResultadoEsperado);
            Emision laEmision = new Emision(losDatos);
            elResultadoObtenido = laEmision.FechaDeGeneracion;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}