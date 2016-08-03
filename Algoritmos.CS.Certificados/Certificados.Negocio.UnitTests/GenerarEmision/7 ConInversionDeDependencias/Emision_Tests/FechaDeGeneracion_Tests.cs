using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace Certificados.Negocio.UnitTests.GenerarEmision.ConInversionDeDependencias.CertificadoDeAutenticacion_Tests
{
    [TestClass]
    public class FechaDeGeneracion_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            DatosDeLaEmision losDatos = Substitute.For<DatosDeLaEmision>();
            DateTime laFecha = new DateTime(2016, 10, 11);
            losDatos.FechaActual.Returns(laFecha);

            Assert.AreEqual(laFecha, losDatos.FechaActual);
        }
    }
}
