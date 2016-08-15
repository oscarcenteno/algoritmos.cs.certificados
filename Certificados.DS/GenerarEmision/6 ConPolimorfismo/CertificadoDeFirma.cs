using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
{
    public class CertificadoDeFirma
    {
        private DatosParaUnCertificadoDigital losDatos;

        public CertificadoDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            losDatos = losDatosDeLaEmision.DatosDeFirma;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(losDatos);
        }
    }
}