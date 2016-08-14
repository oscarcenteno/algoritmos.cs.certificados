using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Mapeable;

namespace Certificados.DS.RegistrarEmision.ComoUnProcedimiento
{
    class ProcesoDeEmision
    {
        public static void RegistreUnaNuevaEmision(DatosDeLaEmision losDatos)
        {
            // Se genera la emision
            Emision laEmision = new Emision(losDatos);

            // Se mapea a los registros de base de datos
            RegistroDeEmision elRegistro = new RegistroDeEmision();
            elRegistro.FechaDeGeneracion = laEmision.FechaDeGeneracion;

            CertificadoDigital elCertificadoDeAutenticacion = laEmision.CertificadoDeAutenticacion;
            elRegistro.CertificadoDeAutenticacion = new Mapeo<CertificadoDigital, RegistroDeCertificado>().Mapee(elCertificadoDeAutenticacion);

            CertificadoDigital elCertificadoDeFirma = laEmision.CertificadoDeFirma;
            elRegistro.CertificadoDeFirma = new Mapeo<CertificadoDigital, RegistroDeCertificado>().Mapee(elCertificadoDeFirma);

            // Se guarda los registros en base de datos
            new RepositorioDeEmisiones().Guarde(elRegistro);
        }
    }
}