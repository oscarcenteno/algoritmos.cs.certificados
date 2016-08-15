using Sujetos;
using System;

namespace Certificados.Negocio.GenerarCertificados.ConParameterObject
{
    public class GeneracionDeCertificadosDigitales
    {
        public static CertificadoDigital GenereUnCertificadoDigital(DatosParaUnCertificadoDigital losDatos)
        {
            CertificadoDigital elCertificado = new CertificadoDigital();

            elCertificado.Sujeto = GenereElSujeto(losDatos);
            elCertificado.FechaDeEmision = losDatos.FechaActual;
            elCertificado.FechaDeVencimiento = GenereLaFechaDeVencimiento(losDatos);
            elCertificado.DireccionDeRevocacion = losDatos.DireccionDeRevocacion;

            return elCertificado;
        }

        private static string GenereElSujeto(DatosParaUnCertificadoDigital losDatos)
        {
            return new Sujeto(losDatos).ComoTexto();
        }

        private static DateTime GenereLaFechaDeVencimiento(DatosParaUnCertificadoDigital losDatos)
        {
            // TODO: No cumple Demeter
            return losDatos.FechaActual.AddYears(losDatos.AñosDeVigencia);
        }
    }
}