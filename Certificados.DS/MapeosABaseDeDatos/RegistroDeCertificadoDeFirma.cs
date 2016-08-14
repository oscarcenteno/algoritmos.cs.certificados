using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Mapeable;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class RegistroDeCertificadoDeFirma
    {
        CertificadoDigital elCertificado;

        public RegistroDeCertificadoDeFirma(Emision laEmision)
        {
            elCertificado = laEmision.CertificadoDeFirma;
        }

        public RegistroDeCertificado Mapeado()
        {
            return new Mapeo<CertificadoDigital, RegistroDeCertificado>().Mapee(elCertificado);
        }
    }
}