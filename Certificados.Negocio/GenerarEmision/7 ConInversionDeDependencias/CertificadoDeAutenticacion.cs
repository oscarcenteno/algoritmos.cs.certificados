using Certificados.Negocio.GenerarCertificados;
using Sujetos;

namespace Certificados.Negocio.GenerarEmision.ConInversionDeDependencias
{
    public class CertificadoDeAutenticacion
    {
        InformacionFormateada laInformacionDeAutenticacion;

        public CertificadoDeAutenticacion(DatosDeLaEmision losDatosDeLaEmision)
        {
            laInformacionDeAutenticacion = losDatosDeLaEmision.InformacionDeAutenticacion;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeAutenticacion);
        }
    }
}