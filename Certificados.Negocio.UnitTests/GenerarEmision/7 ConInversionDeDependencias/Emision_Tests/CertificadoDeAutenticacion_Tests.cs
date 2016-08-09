using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Certificados.Negocio.UnitTests.GenerarEmision_Tests.ConInversionDeDependencias_Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace Certificados.Negocio.UnitTests.GenerarEmision._7_ConInversionDeDependencias.CertificadoDeAutenticacion_Tests
{
    [TestClass]
    public class CertificadoDeAutenticacion_Tests: EscenariosDeDatosDeLaEmision
    {
        private CertificadoDigital elResultadoEsperado;
        private CertificadoDigital elResultadoObtenido;

        [TestMethod]
        public void CertificadoDeAutenticacion_DatosNacionales_CertificadoNacional()
        {
            elResultadoEsperado = ObtengaUnCertificadoNacionalDeAutenticacion();

            Emision laEmision = ObtengaUnaEmisionConDatosNacionalesDeAutenticacion();
            elResultadoObtenido = laEmision.CertificadoDeAutenticacion;

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private Emision ObtengaUnaEmisionConDatosNacionalesDeAutenticacion()
        {
            DatosDeLaEmision losDatos = ObtengaLosDatosDeUnaEmisionNacional();
            return new Emision(losDatos);
        }
    }
}