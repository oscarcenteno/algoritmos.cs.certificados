using System;
using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace Certificados.Negocio.UnitTests.GenerarEmision.ConInversionDeDependencias.CertificadoDeAutenticacion_Tests
{
    [TestClass]
    public class Generado_Tests
    {
        private CertificadoDigital elResultadoEsperado;
        private CertificadoDigital elResultadoObtenido;
        private DatosDeLaEmision losDatos;

        [TestMethod]
        public void Generado_PersonaNacional_CertificadoNacionalDeAutenticacion()
        {
            elResultadoEsperado = InicialiceUnCertificadoNacionalDeAutenticacion();

            InicialiceLosDatosDeUnaEmisionNacional();
            elResultadoObtenido = new CertificadoDeAutenticacion(losDatos).Generado();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private CertificadoDigital InicialiceUnCertificadoNacionalDeAutenticacion()
        {
            throw new NotImplementedException();
        }

        private void InicialiceLosDatosDeUnaEmisionNacional()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Generado_PersonaExtranjera_CertificadoExtranjeroDeAutenticacion()
        {
            elResultadoEsperado = InicialiceUnCertificadoExtranjeroDeAutenticacion();

            InicialiceLosDatosDeUnaEmisionExtranjera();
            elResultadoObtenido = new CertificadoDeAutenticacion(losDatos).Generado();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private CertificadoDigital InicialiceUnCertificadoExtranjeroDeAutenticacion()
        {
            throw new NotImplementedException();
        }

        private void InicialiceLosDatosDeUnaEmisionExtranjera()
        {
            throw new NotImplementedException();
        }
    }
}
