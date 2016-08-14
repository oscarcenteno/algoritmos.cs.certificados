using System;
using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Sujetos;
using Certificados.Negocio.UnitTests.GenerarEmision_Tests.ConInversionDeDependencias_Tests;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.Negocio.UnitTests.GenerarEmision.ConInversionDeDependencias.CertificadoDeAutenticacion_Tests
{
    [TestClass]
    public class Generado_Tests : EscenariosDeDatosDeLaEmision
    {
        private CertificadoDigital elResultadoEsperado;
        private CertificadoDigital elResultadoObtenido;
        private DatosDeLaEmision losDatos;

        [TestMethod]
        public void Generado_PersonaNacional_CertificadoNacionalDeAutenticacion()
        {
            elResultadoEsperado = ObtengaUnCertificadoNacionalDeAutenticacion();

            losDatos = ObtengaLosDatosDeUnaEmisionNacional();
            elResultadoObtenido = new CertificadoDeAutenticacion(losDatos).Generado();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Generado_PersonaExtranjera_CertificadoExtranjeroDeAutenticacion()
        {
            elResultadoEsperado = ObtengaUnCertificadoExtranjeroDeAutenticacion();

            losDatos = ObtengaLosDatosDeUnaEmisionExtranjera();
            elResultadoObtenido = new CertificadoDeAutenticacion(losDatos).Generado();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}