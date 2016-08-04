using Sujetos;
using Mapeable;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
{
    public class DatosDeLaEmisionExtranjera : DatosDeLaEmision
    {
        public override InformacionFormateada InformacionDeAutenticacion
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, InformacionExtranjeraDeAutenticacion>().Mapee(this);
            }
        }

        public override InformacionFormateada InformacionDeFirma
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, InformacionExtranjeraDeFirma>().Mapee(this);
            }
        }
    }
}
