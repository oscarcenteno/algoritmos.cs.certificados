using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.DS.MapeosABaseDeDatos;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Certificados.DS.UnitTests.MapeosABaseDeDatos;
using System;

namespace Certificados.DS.UnitTests.MapeosABaseDeDatos_Tests.RegistroDeEmision_Tests
{
    [TestClass]
    public class FechaDeGeneracion_Tests : EscenariosDeLaEmision
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;
        private Emision laEmision;
        
        [TestMethod]
        public void Mapeado_UnaEmision_LaMismaFechaDeGeneracion()
        {
            elResultadoEsperado = new DateTime(2016, 10, 11);

            laEmision = ObtengaUnaEmisionNacional();
            elResultadoObtenido = new RegistroDeEmision(laEmision).FechaDeGeneracion;

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}