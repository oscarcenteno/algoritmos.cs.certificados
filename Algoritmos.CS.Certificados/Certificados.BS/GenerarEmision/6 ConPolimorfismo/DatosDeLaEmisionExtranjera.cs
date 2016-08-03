using Sujetos;
using Mapeable;

namespace Certificados.BS.GenerarEmision.ConPolimorfismo
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
