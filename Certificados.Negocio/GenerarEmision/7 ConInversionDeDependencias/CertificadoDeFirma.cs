using Sujetos;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.Negocio.GenerarEmision.ConInversionDeDependencias
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