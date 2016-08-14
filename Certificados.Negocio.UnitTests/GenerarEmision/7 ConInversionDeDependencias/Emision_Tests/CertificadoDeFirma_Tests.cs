using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Certificados.Negocio.UnitTests.GenerarEmision_Tests.ConInversionDeDependencias_Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.Negocio.UnitTests.GenerarEmision._7_ConInversionDeDependencias.CertificadoDeFirma_Tests
{
    [TestClass]
    public class CertificadoDeFirma_Tests : EscenariosDeDatosDeLaEmision
    {
        private CertificadoDigital elResultadoEsperado;
        private CertificadoDigital elResultadoObtenido;

        [TestMethod]
        public void CertificadoDeFirma_DatosNacionales_CertificadoNacional()
        {
            elResultadoEsperado = ObtengaUnCertificadoNacionalDeFirma();

            Emision laEmision = ObtengaUnaEmisionConDatosNacionalesDeFirma();
            elResultadoObtenido = laEmision.CertificadoDeFirma;

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private Emision ObtengaUnaEmisionConDatosNacionalesDeFirma()
        {
            DatosDeLaEmision losDatos = ObtengaLosDatosDeUnaEmisionNacional();
            return new Emision(losDatos);
        }
    }
}