using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using System;

namespace Certificados.Negocio.UnitTests.GenerarCertificados.ConPolimorfismo
{
    public class EscenariosDeCertificados
    {
        DatosParaUnCertificadoDigital losDatos;

        protected CertificadoDigital ObtengaUnCertificadoNacionalDeAutenticacion()
        {
            losDatos = new DatosParaUnCertificadoDigitalNacionalDeAutenticacion();
            InicialiceUnaPersona();
            return new CertificadoDigital(losDatos);
        }

        private void InicialiceUnaPersona()
        {
            losDatos.Nombre = "Miguel";
            losDatos.PrimerApellido = "Suarez";
            losDatos.SegundoApellido = "Godinez";
            losDatos.Identificacion = "3034560333";
            losDatos.DireccionDeRevocacion = "http://direccionderevocacion.com";
            losDatos.AñosDeVigencia = 4;
            losDatos.FechaActual = new DateTime(2016, 10, 11);
        }

        protected CertificadoDigital ObtengaUnCertificadoNacionalDeFirma()
        {
            losDatos = new DatosParaUnCertificadoDigitalNacionalDeFirma();
            InicialiceUnaPersona();
            return new CertificadoDigital(losDatos);
        }


        protected CertificadoDigital ObtengaUnCertificadoExtranjeroDeAutenticacion()
        {
            losDatos = new DatosParaUnCertificadoDigitalExtranjeroDeAutenticacion();
            InicialiceUnaPersona();
            return new CertificadoDigital(losDatos);
        }

        protected CertificadoDigital ObtengaUnCertificadoExtranjeroDeFirma()
        {
            losDatos = new DatosParaUnCertificadoDigitalExtranjeroDeFirma();
            InicialiceUnaPersona();
            return new CertificadoDigital(losDatos);
        }
    }
}