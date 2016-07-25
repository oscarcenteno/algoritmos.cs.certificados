using Certificados.Negocio.GenerarCertificados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificados.Negocio.UnitTests.GenerarCertificados
{
    public class Escenarios
    {
        protected CertificadoDigital elCertificado;
        protected string elNombre;
        protected string elPrimerApellido;
        protected string elSegundoApellido;
        protected TipoDeCertificado elTipoDeCertificado;
        protected TipoDeIdentificacion elTipoDeIdentificacion;
        protected string laDireccionDeRevocacion;
        protected DateTime laFechaActual;
        protected string laIdentificacion;
        protected int losAñosDeVigencia;

        protected void InicialiceEscenarioNacionalDeAutenticacion()
        {
            elTipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;

            InicialiceUnaPersona();
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
            elCertificado = GeneracionDeCertificadosDigitales.GenereUnCertificadoDigital(elNombre, elPrimerApellido, elSegundoApellido, laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado, laFechaActual, laDireccionDeRevocacion, losAñosDeVigencia);
        }

        protected void InicialiceEscenarioNacionalDeFirma()
        {
            elTipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            elTipoDeCertificado = TipoDeCertificado.Firma;
            InicialiceUnaPersona();
        }

        protected void InicialiceEscenarioExtranjeroDeAutenticacion()
        {
            elTipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;
            InicialiceUnaPersona();
        }


        protected void InicialiceEscenarioExtranjeroDeFirma()
        {
            elTipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            elTipoDeCertificado = TipoDeCertificado.Firma;
            InicialiceUnaPersona();
        }
    }
}