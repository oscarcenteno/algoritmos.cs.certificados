using System;
using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Sujetos;
using Certificados.Negocio.UnitTests.GenerarEmision_Tests.ConInversionDeDependencias_Tests;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.Negocio.UnitTests.GenerarEmision.ConInversionDeDependencias.CertificadoDeFirma_Tests
{
    [TestClass]
    public class Generado_Tests : EscenariosDeDatosDeLaEmision
    {
        private CertificadoDigital elResultadoEsperado;
        private CertificadoDigital elResultadoObtenido;
        private DatosDeLaEmision losDatos;

        [TestMethod]
        public void Generado_PersonaNacional_CertificadoNacionalDeFirma()
        {
            elResultadoEsperado = ObtengaUnCertificadoNacionalDeFirma();

            losDatos = ObtengaLosDatosDeUnaEmisionNacional();
            elResultadoObtenido = new CertificadoDeFirma(losDatos).Generado();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Generado_PersonaExtranjera_CertificadoExtranjeroDeFirma()
        {
            elResultadoEsperado = ObtengaUnCertificadoExtranjeroDeFirma();

            losDatos = ObtengaLosDatosDeUnaEmisionExtranjera();
            elResultadoObtenido = new CertificadoDeFirma(losDatos).Generado();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}