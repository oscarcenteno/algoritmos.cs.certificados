using Sujetos;
using Certificados.Negocio.GenerarCertificados;

namespace Certificados.BS.GenerarEmision.ConPolimorfismo
{
    public class CertificadoDeFirma
    {
        private InformacionFormateada laInformacionDeFirma;

        public CertificadoDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            laInformacionDeFirma = losDatosDeLaEmision.InformacionDeFirma;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeFirma);
        }
    }
}