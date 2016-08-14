using Sujetos;
using System;

namespace Certificados.Negocio.GenerarCertificados.ConFunciones
{
    public class GeneracionDeCertificadosDigitales
    {
        public static CertificadoDigital GenereUnCertificadoDigital(string elNombre,
            string elPrimerApellido,
            string elSegundoApellido,
            string laIdentificacion,
            TipoDeIdentificacion elTipoDeIdentificacion,
            TipoDeCertificado elTipoDeCertificado,
            DateTime laFechaActual,
            string laDireccionDeRevocacion,
            int losAñosDeVigencia)
        {
            CertificadoDigital elCertificado = new CertificadoDigital();

            elCertificado.Sujeto = ObtengaElSujeto(elNombre, elPrimerApellido, elSegundoApellido, laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado);
            elCertificado.FechaDeEmision = laFechaActual;
            elCertificado.FechaDeVencimiento = GenereLaFechaDeVencimiento(laFechaActual, losAñosDeVigencia);
            elCertificado.DireccionDeRevocacion = laDireccionDeRevocacion;

            return elCertificado;
        }

        private static string ObtengaElSujeto(string elNombre, string elPrimerApellido, string elSegundoApellido, string laIdentificacion, TipoDeIdentificacion elTipoDeIdentificacion, TipoDeCertificado elTipoDeCertificado)
        {
            InformacionFormateada laInformacion;
            laInformacion = DetermineElTipoDeInformacion(elTipoDeIdentificacion, elTipoDeCertificado);
            laInformacion.Nombre = elNombre;
            laInformacion.PrimerApellido = elPrimerApellido;
            laInformacion.SegundoApellido = elSegundoApellido;
            laInformacion.Identificacion = laIdentificacion;

            return GenereElSujeto(laInformacion);
        }

        private static InformacionFormateada DetermineElTipoDeInformacion(TipoDeIdentificacion elTipoDeIdentificacion, TipoDeCertificado elTipoDeCertificado)
        {
            if (EsDeAutenticacion(elTipoDeCertificado))
                return DetermineElTipoDeIdentificacionDeAutenticacion(elTipoDeIdentificacion);
            else
                return DetermineElTipoDeIdentificacionDeFirma(elTipoDeIdentificacion);
        }

        private static bool EsDeAutenticacion(TipoDeCertificado elTipoDeCertificado)
        {
            return elTipoDeCertificado == TipoDeCertificado.Autenticacion;
        }

        private static InformacionFormateada DetermineElTipoDeIdentificacionDeFirma(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return new InformacionNacionalDeFirma();
            else
                return new InformacionExtranjeraDeFirma();
        }

        private static bool EsNacional(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            return elTipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        private static InformacionFormateada DetermineElTipoDeIdentificacionDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return new InformacionNacionalDeAutenticacion();
            else
                return new InformacionExtranjeraDeAutenticacion();
        }

        private static string GenereElSujeto(InformacionFormateada laInformacion)
        {
            return new SujetoFormateado(laInformacion).ComoTexto();
        }

        private static DateTime GenereLaFechaDeVencimiento(DateTime laFechaActual, int losAñosDeVigencia)
        {
            return laFechaActual.AddYears(losAñosDeVigencia);
        }
    }
}