using System;

namespace Certificados.Negocio.GenerarCertificados
{
    public static class GeneracionDeCertificadosDigitales
    {
        public static CertificadoDigital GenereUnCertificadoDigital(DatosDeUnCertificadoDigital losDatos)
        {
            CertificadoDigital elCertificado = new CertificadoDigital();

            elCertificado.Sujeto = GenereElSujeto(losDatos);
            elCertificado.FechaDeEmision = losDatos.FechaActual;
            elCertificado.FechaDeVencimiento = GenereLaFechaDeVencimiento(losDatos);
            elCertificado.DireccionDeRevocacion = losDatos.DireccionDeRevocacion;

            return elCertificado;
        }

        private static string GenereElSujeto(DatosDeUnCertificadoDigital losDatos)
        {
            return new Sujeto(losDatos).ComoTexto();
        }
        
        private static DateTime GenereLaFechaDeVencimiento(DatosDeUnCertificadoDigital losDatos)
        {
            return losDatos.FechaDeVencimiento;
        }
    }
}