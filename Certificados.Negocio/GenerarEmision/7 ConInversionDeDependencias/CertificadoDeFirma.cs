using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.Negocio.GenerarEmision.ConInversionDeDependencias
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