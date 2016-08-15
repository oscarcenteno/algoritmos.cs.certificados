using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Mapeable;

namespace Certificados.Negocio.GenerarEmision.ConInversionDeDependencias
{
    public abstract class DatosDeLaEmisionNacional : DatosDeLaEmision
    {
        public override DatosParaUnCertificadoDigital DatosDeAutenticacion
        {
            get
            {
                return new Mapeo<DatosDeLaEmisionNacional, DatosParaUnCertificadoDigitalNacionalDeAutenticacion>().Mapee(this);
            }
        }

        public override DatosParaUnCertificadoDigital DatosDeFirma
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, DatosParaUnCertificadoDigitalNacionalDeFirma>().Mapee(this);
            }
        }
    }
}