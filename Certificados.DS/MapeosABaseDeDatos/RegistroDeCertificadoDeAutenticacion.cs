using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Mapeable;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class RegistroDeCertificadoDeAutenticacion
    {
        CertificadoDigital elCertificado;

        public RegistroDeCertificadoDeAutenticacion(Emision laEmision)
        {
            elCertificado = laEmision.CertificadoDeAutenticacion;
        }

        public RegistroDeCertificado Mapeado()
        {
            return new Mapeo<CertificadoDigital, RegistroDeCertificado>().Mapee(elCertificado);
        }
    }
}