using System;

namespace Certificados.Negocio.GenerarCertificados.ConPolimorfismo
{
    public class GeneracionDeCertificadosDigitales
    {
        public static CertificadoDigital GenereUnCertificadoDigital(DatosParaUnCertificadoDigital losDatos)
        {
            return new CertificadoDigital(losDatos);
        }
    }
}