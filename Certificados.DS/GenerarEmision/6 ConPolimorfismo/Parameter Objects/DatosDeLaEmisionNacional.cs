using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Mapeable;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
{
    public class DatosDeLaEmisionNacional : DatosDeLaEmision
    {
        public override DatosParaUnCertificadoDigital DatosDeAutenticacion
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, 
                    DatosParaUnCertificadoDigitalNacionalDeAutenticacion>().Mapee(this);
            }
        }

        public override DatosParaUnCertificadoDigital DatosDeFirma
        {
            get
            {
                return new Mapeo<DatosDeLaEmision,
                  DatosParaUnCertificadoDigitalNacionalDeFirma>().Mapee(this);
            }
        }
    }
}