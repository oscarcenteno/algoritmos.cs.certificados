using System;

namespace Certificados.Negocio.GenerarCertificados.ConTellDontAsk
{
    public class GeneracionDeCertificadosDigitales
    {
        public static CertificadoDigital GenereUnCertificadoDigital(DatosParaUnCertificadoDigital losDatos)
        {
            return new CertificadoDigital(losDatos);
        }
    }
}