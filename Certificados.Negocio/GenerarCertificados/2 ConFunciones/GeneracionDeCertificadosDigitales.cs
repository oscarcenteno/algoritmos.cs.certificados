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

            // Genere el sujeto
            InformacionFormateada laInformacion;
            // si el proposito es de autenticacion

            if (elTipoDeCertificado == TipoDeCertificado.Autenticacion)
            {
                // Si es nacional
                if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                {
                    laInformacion = new InformacionNacionalDeAutenticacion();
                }
                else
                {
                    laInformacion = new InformacionExtranjeraDeAutenticacion();
                }
            }
            else
            {
                // Si es nacional
                if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                {
                    laInformacion = new InformacionNacionalDeFirma();
                }
                else
                {
                    laInformacion = new InformacionExtranjeraDeFirma();
                }
            }

            laInformacion.Nombre = elNombre;
            laInformacion.PrimerApellido = elPrimerApellido;
            laInformacion.SegundoApellido = elSegundoApellido;
            laInformacion.Identificacion = laIdentificacion;
            elCertificado.Sujeto = new SujetoFormateado(laInformacion).ComoTexto();

            elCertificado.FechaDeEmision = laFechaActual;
            // se genera de acuerdo a la vigencia
            elCertificado.FechaDeVencimiento = laFechaActual.AddYears(losAñosDeVigencia);
            elCertificado.DireccionDeRevocacion = laDireccionDeRevocacion;

            return elCertificado;
        }
    }
}