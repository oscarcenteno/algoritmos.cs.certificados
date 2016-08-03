using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class MapeoDelRegistroDeEmision
    {
        Emision laEmision;

        public MapeoDelRegistroDeEmision(DatosDeLaEmision losDatos)
        {
            laEmision = new Emision(losDatos);
        }

        public RegistroDeEmision ComoRegistro()
        {
            return new RegistroDeEmision(laEmision);
        }
    }
}