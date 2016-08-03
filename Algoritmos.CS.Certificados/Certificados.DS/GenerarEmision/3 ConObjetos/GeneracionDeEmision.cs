namespace Certificados.DS.GenerarEmision.ConObjetos
{
    public static class GeneracionDeEmision
    {
        public static Emision GenereLaEmision(TipoDeIdentificacion elTipoDeIdentificacion,
            string laIdentificacion,
            string elNombre,
            string elPrimerApellido,
            string elSegundoApellido)
        {
            return new EmisionConDependencias(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido).ComoObjeto();
        }
    }
}