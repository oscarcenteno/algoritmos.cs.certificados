namespace Sujetos
{
    public static class GeneracionDeSujetos
    {
        public static string GenereElSujeto(InformacionFormateada laInformacion)
        {
            return new SujetoFormateado(laInformacion).ComoTexto();
        }
    }
}