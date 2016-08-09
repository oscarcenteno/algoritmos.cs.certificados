using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.DS.MapeosABaseDeDatos;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Certificados.DS.UnitTests.MapeosABaseDeDatos;

namespace Certificados.DS.UnitTests.MapeosABaseDeDatos_Tests.RegistroDeCertificadoDeAutenticacion_Tests
{
    [TestClass]
    public class Mapeado_Tests : EscenariosDeLaEmision
    {
        private RegistroDeCertificado elResultadoEsperado;
        private RegistroDeCertificado elResultadoObtenido;
        private Emision laEmision;

        [TestMethod]
        public void Mapeado_UnaEmision_RegistroDelCertificadoDeAutenticacion()
        {
            elResultadoEsperado = ObtengaUnRegistroDeCertificadoNacionalDeAutenticacion();

            laEmision = ObtengaUnaEmisionNacional();
            elResultadoObtenido = new RegistroDeCertificadoDeAutenticacion(laEmision).Mapeado();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}