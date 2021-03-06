﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels;

namespace WebApplication1.UnitTests.Certificados.Consultar_los_certificados.View_Models.EmisionRealizadaVista_Tests
{
    [TestClass]
    public class IDComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private EmisionRealizadaVista laVista;

        [TestMethod]
        public void IDComoTexto_CasoUnico_ComoString()
        {
            elResultadoEsperado = "987";

            InicialiceLaVista();
            elResultadoObtenido = laVista.IDComoTexto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLaVista()
        {
            laVista = new EmisionRealizadaVista();
            laVista.ID = 987;
        }
    }
}
