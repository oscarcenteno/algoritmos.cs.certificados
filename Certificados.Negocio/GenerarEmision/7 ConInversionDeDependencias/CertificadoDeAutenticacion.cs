using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.Negocio.GenerarEmision.ConInversionDeDependencias
{
    public class CertificadoDeAutenticacion
    {
        DatosParaUnCertificadoDigital losDatos;

        public CertificadoDeAutenticacion(DatosDeLaEmision losDatosDeLaEmision)
        {
            losDatos = losDatosDeLaEmision.DatosDeAutenticacion;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(losDatos);
        }
    }
}