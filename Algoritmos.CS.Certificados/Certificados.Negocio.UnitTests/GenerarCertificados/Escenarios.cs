using Certificados.Negocio.GenerarCertificados;
using System;

namespace Certificados.Negocio.UnitTests.GenerarCertificados
{
    public class Escenarios
    {
        protected CertificadoDigital elCertificado;
        protected DatosDeUnCertificadoDigital losDatos;

        protected void InicialiceEscenarioNacionalDeAutenticacion()
        {
            losDatos = new DatosDeUnCertificadoDigital();
            losDatos.TipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            losDatos.TipoDeCertificado = TipoDeCertificado.Autenticacion;

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
            elCertificado = GeneracionDeCertificadosDigitales.GenereUnCertificadoDigital(losDatos);
        }

        protected void InicialiceEscenarioNacionalDeFirma()
        {
            losDatos = new DatosDeUnCertificadoDigital();
            losDatos.TipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            losDatos.TipoDeCertificado = TipoDeCertificado.Firma;
            InicialiceUnaPersona();
        }

        protected void InicialiceEscenarioExtranjeroDeAutenticacion()
        {
            losDatos = new DatosDeUnCertificadoDigital();
            losDatos.TipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            losDatos.TipoDeCertificado = TipoDeCertificado.Autenticacion;
            InicialiceUnaPersona();
        }

        protected void InicialiceEscenarioExtranjeroDeFirma()
        {
            losDatos = new DatosDeUnCertificadoDigital();
            losDatos.TipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            losDatos.TipoDeCertificado = TipoDeCertificado.Firma;
            InicialiceUnaPersona();
        }
    }
}