using Certificados.Negocio.GenerarCertificados.ComoUnProcedimiento;
using System;

namespace Certificados.Negocio.UnitTests.GenerarCertificados.ComoUnProcedimiento
{
    public class EscenariosDeCertificados
    {
        string elNombre;
        string elPrimerApellido;
        string elSegundoApellido;
        string laIdentificacion;
        TipoDeIdentificacion elTipoDeIdentificacion;
        TipoDeCertificado elTipoDeCertificado;
        DateTime laFechaActual;
        string laDireccionDeRevocacion;
        int losAñosDeVigencia;

        protected CertificadoDigital ObtengaUnCertificadoNacionalDeAutenticacion()
        {
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;
            elTipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            InicialiceUnaPersona();
            return ObtengaElCertificado();
        }

        private void InicialiceUnaPersona()
        {
            elNombre = "Miguel";
            elPrimerApellido = "Suarez";
            elSegundoApellido = "Godinez";
            laIdentificacion = "3034560333";
            laDireccionDeRevocacion = "http://direccionderevocacion.com";
            losAñosDeVigencia = 4;
            laFechaActual = new DateTime(2016, 10, 11);
        }

        protected CertificadoDigital ObtengaUnCertificadoNacionalDeFirma()
        {
            elTipoDeCertificado = TipoDeCertificado.Firma;
            elTipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            InicialiceUnaPersona();
            return ObtengaElCertificado();
        }

        private CertificadoDigital ObtengaElCertificado()
        {
            return GeneracionDeCertificadosDigitales.GenereUnCertificadoDigital(elNombre,
                            elPrimerApellido,
                            elSegundoApellido,
                            laIdentificacion,
                            elTipoDeIdentificacion,
                            elTipoDeCertificado,
                            laFechaActual,
                            laDireccionDeRevocacion,
                            losAñosDeVigencia);
        }

        protected CertificadoDigital ObtengaUnCertificadoExtranjeroDeAutenticacion()
        {
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;
            elTipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            InicialiceUnaPersona();
            return ObtengaElCertificado();
        }

        protected CertificadoDigital ObtengaUnCertificadoExtranjeroDeFirma()
        {
            elTipoDeCertificado = TipoDeCertificado.Firma;
            elTipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            InicialiceUnaPersona();
            return ObtengaElCertificado();
        }
    }
}