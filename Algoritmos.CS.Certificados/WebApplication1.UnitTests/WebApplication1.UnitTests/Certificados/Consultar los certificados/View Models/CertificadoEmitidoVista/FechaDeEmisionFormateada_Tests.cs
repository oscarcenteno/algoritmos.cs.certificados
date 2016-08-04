using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Certificados.ConsultarLosCertificados.ViewModels;

namespace WebApplication1.UnitTests.Certificados.Consultar_los_certificados.View_Models.CertificadoEmitidoVista_Tests
{
    [TestClass]
    public class FechaDeEmisionFormateada_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private CertificadoEmitidoVista laVista;

        [TestInitialize]
        public void Inicialice()
        {
            laVista = new CertificadoEmitidoVista();
            laVista.FechaDeEmision = new DateTime(2016, 12, 9);
        }

        [TestMethod]
        public void FechaDeEmisionFormateada_CasoUnico_ComoString()
        {
            elResultadoEsperado = "2016-12-09";

            elResultadoObtenido = laVista.FechaDeEmisionFormateada;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
