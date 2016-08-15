using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
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