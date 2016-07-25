using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.Negocio.GenerarCertificados;

namespace Certificados.Negocio.UnitTests.GenerarCertificados
{
    [TestClass]

    public class GenereUnCertificadoDigital_Tests:Escenarios
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void DireccionDeRevocacion_UnaDireccion_LaMisma()
        {
            elResultadoEsperado = "http://direccionderevocacion.com";

            InicialiceEscenarioNacionalDeAutenticacion();
            elResultadoObtenido = elCertificado.DireccionDeRevocacion;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
