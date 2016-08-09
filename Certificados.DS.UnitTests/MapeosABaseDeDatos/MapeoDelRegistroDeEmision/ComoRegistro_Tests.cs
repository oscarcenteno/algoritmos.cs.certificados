using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.DS.MapeosABaseDeDatos;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Certificados.DS.UnitTests.MapeosABaseDeDatos;

namespace Certificados.DS.UnitTests
{
    [TestClass]
    public class ComoRegistro_Tests : EscenariosDeLaEmision
    {
        private RegistroDeEmision elResultadoEsperado;
        private RegistroDeEmision elResultadoObtenido;
        private DatosDeLaEmision losDatos;

        [TestMethod]
        public void ComoRegistro_UnaEmision_MapeadaComoRegistro()
        {
            elResultadoEsperado = ObtengaUnRegistroDeEmisionNacional();

            losDatos = ObtengaLosDatosDeUnaEmisionNacional();
            elResultadoObtenido = new MapeoDelRegistroDeEmision(losDatos).ComoRegistro();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private RegistroDeEmision ObtengaUnRegistroDeEmisionNacional()
        {
            RegistroDeEmision elRegistro = new RegistroDeEmision();
            elRegistro.CertificadoDeAutenticacion = ObtengaUnRegistroDeCertificadoNacionalDeAutenticacion();
            elRegistro.CertificadoDeFirma = ObtengaUnRegistroDeCertificadoNacionalDeFirma();
            elRegistro.FechaDeGeneracion = new DateTime(2016, 10, 11);

            return elRegistro;
        }
    }
}