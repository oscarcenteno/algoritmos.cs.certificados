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
            InformacionFormateada laInformacion = ObtengaLaInformacionFormateada(elNombre, elPrimerApellido, elSegundoApellido, laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado);

            return GenereElSujetoFormateado(laInformacion);
        }

        private static InformacionFormateada ObtengaLaInformacionFormateada(string elNombre, string elPrimerApellido, string elSegundoApellido, string laIdentificacion, TipoDeIdentificacion elTipoDeIdentificacion, TipoDeCertificado elTipoDeCertificado)
        {
            InformacionFormateada laInformacion = ObtengaLaInformacionFormateada(elTipoDeIdentificacion, elTipoDeCertificado);
            laInformacion.Nombre = elNombre;
            laInformacion.PrimerApellido = elPrimerApellido;
            laInformacion.SegundoApellido = elSegundoApellido;
            laInformacion.Identificacion = laIdentificacion;

            return laInformacion;
        }

        private static InformacionFormateada ObtengaLaInformacionFormateada(TipoDeIdentificacion elTipoDeIdentificacion, TipoDeCertificado elTipoDeCertificado)
        {
            if (ElPropositoEsDeAutenticacion(elTipoDeCertificado))
                return ObtengaLaInformacionDeAutenticacion(elTipoDeIdentificacion);
            else
                return ObtengaLaInformacionDeFirma(elTipoDeIdentificacion);
        }

        private static bool ElPropositoEsDeAutenticacion(TipoDeCertificado elTipoDeCertificado)
        {
            return elTipoDeCertificado == TipoDeCertificado.Autenticacion;
        }

        private static InformacionFormateada ObtengaLaInformacionDeFirma(TipoDeIdentificacion elTipoDeIdentificacion)
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

        private static InformacionFormateada ObtengaLaInformacionDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return new InformacionNacionalDeAutenticacion();
            else
                return new InformacionExtranjeraDeAutenticacion();
        }

        private static string GenereElSujetoFormateado(InformacionFormateada laInformacion)
        {
            return new SujetoFormateado(laInformacion).ComoTexto();
        }

        private static DateTime GenereLaFechaDeVencimiento(DateTime laFechaActual, int losAñosDeVigencia)
        {
            return laFechaActual.AddYears(losAñosDeVigencia);
        }
    }
}