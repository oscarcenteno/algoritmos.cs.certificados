using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;

namespace Certificados.BS.RegistrarEmision.ConObjetos
{
    public class ProcesoDeEmision
    {
        private RegistroDeEmision elRegistro;

        public ProcesoDeEmision(DatosDeLaEmision losDatos)
        {
            elRegistro = new MapeoDelRegistroDeEmision(losDatos).ComoRegistro();
        }

        public void Ejecute()
        {
            new RepositorioDeEmisiones().Guarde(elRegistro);
        }
    }
}