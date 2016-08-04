using Certificados.Negocio.GenerarCertificados;
using Sujetos;
using System;

namespace Certificados.Negocio.UnitTests.GenerarCertificados
{
    public class Escenarios
    {
        protected CertificadoDigital elCertificado;
        protected InformacionFormateada losDatos;

        protected void InicialiceEscenarioNacionalDeAutenticacion()
        {
            losDatos = new InformacionNacionalDeAutenticacion();
            InicialiceUnaPersona();
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
            elCertificado = new CertificadoDigital(losDatos);
        }

        protected void InicialiceEscenarioNacionalDeFirma()
        {
            losDatos = new InformacionNacionalDeFirma();
            InicialiceUnaPersona();
        }

        protected void InicialiceEscenarioExtranjeroDeAutenticacion()
        {
            losDatos = new InformacionExtranjeraDeAutenticacion();
            InicialiceUnaPersona();
        }

        protected void InicialiceEscenarioExtranjeroDeFirma()
        {
            losDatos = new InformacionExtranjeraDeFirma();
            InicialiceUnaPersona();
        }
    }
}