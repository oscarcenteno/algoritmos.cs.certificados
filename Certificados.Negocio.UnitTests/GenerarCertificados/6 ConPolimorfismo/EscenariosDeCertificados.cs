using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Sujetos;
using System;

namespace Certificados.Negocio.UnitTests.GenerarCertificados.ConPolimorfismo
{
    public class EscenariosDeCertificados
    {
        InformacionFormateada laInformacion;

        protected CertificadoDigital ObtengaUnCertificadoNacionalDeAutenticacion()
        {
            laInformacion = new InformacionNacionalDeAutenticacion();
            InicialiceUnaPersona();
            return new CertificadoDigital(laInformacion);
        }

        private void InicialiceUnaPersona()
        {
            laInformacion.Nombre = "Miguel";
            laInformacion.PrimerApellido = "Suarez";
            laInformacion.SegundoApellido = "Godinez";
            laInformacion.Identificacion = "3034560333";
            laInformacion.DireccionDeRevocacion = "http://direccionderevocacion.com";
            laInformacion.AñosDeVigencia = 4;
            laInformacion.FechaActual = new DateTime(2016, 10, 11);
        }

        protected CertificadoDigital ObtengaUnCertificadoNacionalDeFirma()
        {
            laInformacion = new InformacionNacionalDeFirma();
            InicialiceUnaPersona();
            return new CertificadoDigital(laInformacion);
        }


        protected CertificadoDigital ObtengaUnCertificadoExtranjeroDeAutenticacion()
        {
            laInformacion = new InformacionExtranjeraDeAutenticacion();
            InicialiceUnaPersona();
            return new CertificadoDigital(laInformacion);
        }

        protected CertificadoDigital ObtengaUnCertificadoExtranjeroDeFirma()
        {
            laInformacion = new InformacionExtranjeraDeFirma();
            InicialiceUnaPersona();
            return new CertificadoDigital(laInformacion);
        }
    }
}