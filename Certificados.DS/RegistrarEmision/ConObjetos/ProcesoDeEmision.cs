using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;

namespace Certificados.BS.RegistrarEmision.ConObjetos
{
    public static class ProcesoDeEmision
    {
        public static void Ejecute(DatosDeLaEmision losDatos)
        {
            RegistroDeEmision elRegistro;
            elRegistro = new MapeoDelRegistroDeEmision(losDatos).ComoRegistro();
            new RepositorioDeEmisiones().Guarde(elRegistro);
        }
    }
}