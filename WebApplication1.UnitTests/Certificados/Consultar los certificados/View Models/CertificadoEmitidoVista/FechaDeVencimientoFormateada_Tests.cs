using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Certificados.ConsultarLosCertificados.ViewModels;

namespace WebApplication1.UnitTests.Certificados.Consultar_los_certificados.View_Models.CertificadoEmitidoVista_Tests
{
    [TestClass]
    public class FechaDeVencimientoFormateada_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private CertificadoVista laVista;

        [TestMethod]
        public void FechaDeVencimientoFormateada_CasoUnico_ComoString()
        {
            elResultadoEsperado = "2016-12-09";

            InicialiceLaVista();
            elResultadoObtenido = laVista.FechaDeVencimientoFormateada;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLaVista()
        {
            laVista = new CertificadoVista();
            laVista.FechaDeVencimiento = new DateTime(2016, 12, 9);
        }
    }
}
