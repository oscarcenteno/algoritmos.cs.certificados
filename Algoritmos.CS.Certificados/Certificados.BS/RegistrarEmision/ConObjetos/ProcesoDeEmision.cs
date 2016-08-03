using Certificados.DS.RegistrarEmision;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;

namespace Certificados.BS.RegistrarEmision.ConObjetos
{
    class ProcesoDeEmision
    {
        public static void RegistreUnaNuevaEmision(DatosDeLaEmision losDatos)
        {
            RegistroDeEmision elRegistro = GenereElRegistroDeLaEmisionMapeada(losDatos);

            GuardeEnBaseDeDatos(elRegistro);
        }

        private static void GuardeEnBaseDeDatos(RegistroDeEmision elRegistro)
        {
            // Se guarda los registros en base de datos
            new RepositorioDeEmision().Guarde(elRegistro);
        }

        private static RegistroDeEmision GenereElRegistroDeLaEmisionMapeada(DatosDeLaEmision losDatos)
        {
            return new MapeoDelRegistroDeEmision(losDatos).ComoRegistro();
        }
    }
}