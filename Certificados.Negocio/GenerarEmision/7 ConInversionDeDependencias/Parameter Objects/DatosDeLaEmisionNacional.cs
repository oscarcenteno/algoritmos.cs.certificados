using Mapeable;
using Sujetos;

namespace Certificados.Negocio.GenerarEmision.ConInversionDeDependencias
{
    public abstract class DatosDeLaEmisionNacional : DatosDeLaEmision
    {
        public override InformacionFormateada InformacionDeAutenticacion
        {
            get
            {
                return new Mapeo<DatosDeLaEmisionNacional, InformacionNacionalDeAutenticacion>().Mapee(this);
            }
        }

        public override InformacionFormateada InformacionDeFirma
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, InformacionNacionalDeFirma>().Mapee(this);
            }
        }
    }
}