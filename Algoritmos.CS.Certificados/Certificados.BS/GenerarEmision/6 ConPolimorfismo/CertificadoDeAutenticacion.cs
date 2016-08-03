using Certificados.Negocio.GenerarCertificados;
using Sujetos;

namespace Certificados.BS.GenerarEmision.ConPolimorfismo
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