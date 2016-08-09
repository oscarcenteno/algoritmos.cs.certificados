using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Certificados.Negocio.UnitTests.GenerarEmision_Tests.ConInversionDeDependencias_Tests;
using System;

namespace Certificados.DS.UnitTests.MapeosABaseDeDatos
{
    public class EscenariosDeLaEmision: EscenariosDeDatosDeLaEmision
    {
        public RegistroDeCertificado ObtengaUnRegistroDeCertificadoNacionalDeAutenticacion()
        {
            RegistroDeCertificado elRegistro = new RegistroDeCertificado();
            elRegistro.ID = 0;
            elRegistro.Sujeto = "CN=MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=CPF-3034560333";
            elRegistro.DireccionDeRevocacion = "http://direccionderevocacion.com";
            elRegistro.FechaDeEmision = new DateTime(2016, 10, 11);
            elRegistro.FechaDeVencimiento = new DateTime(2020, 10, 11);

            return elRegistro;
        }

        public RegistroDeCertificado ObtengaUnRegistroDeCertificadoNacionalDeFirma()
        {
            RegistroDeCertificado elRegistro = new RegistroDeCertificado();
            elRegistro.ID = 0;
            elRegistro.Sujeto = "CN=MIGUEL SUAREZ GODINEZ (FIRMA), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=CPF-3034560333";
            elRegistro.DireccionDeRevocacion = "http://direccionderevocacion.com";
            elRegistro.FechaDeEmision = new DateTime(2016, 10, 11);
            elRegistro.FechaDeVencimiento = new DateTime(2020, 10, 11);

            return elRegistro;
        }

        public Emision ObtengaUnaEmisionNacional()
        {
            DatosDeLaEmisionNacional losDatosDeLaEmision;
            losDatosDeLaEmision = ObtengaLosDatosDeUnaEmisionNacional();

            return new Emision(losDatosDeLaEmision);
        }
    }
}