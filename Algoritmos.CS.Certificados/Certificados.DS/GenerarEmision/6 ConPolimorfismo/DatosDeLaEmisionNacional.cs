using Mapeable;
using Sujetos;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
{
    public class DatosDeLaEmisionNacional : DatosDeLaEmision
    {
        public override InformacionFormateada InformacionDeAutenticacion
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, InformacionNacionalDeAutenticacion>().Mapee(this);
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