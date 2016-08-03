namespace Certificados.DS.GenerarEmision.ConParameterObject
{
    public static class GeneracionDeEmision
    {
        public static Emision GenereLaEmision(DatosDelSolicitante losDatosDelSolicitante)
        {
            return new EmisionConDependencias(losDatosDelSolicitante).ComoObjeto();
        }
    }
}