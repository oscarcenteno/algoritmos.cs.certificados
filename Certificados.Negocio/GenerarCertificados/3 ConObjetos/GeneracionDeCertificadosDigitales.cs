using Sujetos;
using System;

namespace Certificados.Negocio.GenerarCertificados.ConObjetos
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

            elCertificado.Sujeto = GenereElSujeto(elNombre, elPrimerApellido, elSegundoApellido, laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado);
            elCertificado.FechaDeEmision = laFechaActual;
            elCertificado.FechaDeVencimiento = GenereLaFechaDeVencimiento(laFechaActual, losAñosDeVigencia);
            elCertificado.DireccionDeRevocacion = laDireccionDeRevocacion;

            return elCertificado;
        }

        private static string GenereElSujeto(string elNombre,
            string elPrimerApellido,
            string elSegundoApellido,
            string laIdentificacion,
            TipoDeIdentificacion elTipoDeIdentificacion,
            TipoDeCertificado elTipoDeCertificado)
        {
            return new Sujeto(elNombre, elPrimerApellido, elSegundoApellido, laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado).ComoTexto();
        }

        private static DateTime GenereLaFechaDeVencimiento(DateTime laFechaActual, int losAñosDeVigencia)
        {
            return laFechaActual.AddYears(losAñosDeVigencia);
        }
    }
}