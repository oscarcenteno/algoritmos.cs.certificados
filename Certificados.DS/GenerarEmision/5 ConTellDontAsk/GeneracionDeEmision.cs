namespace Certificados.DS.GenerarEmision.ConTellDontAsk
{
    public static class GeneracionDeEmision
    {
        public static Emision GenereLaEmision(DatosDeLaEmision losDatosDeLaEmision)
        {
            return new Emision(losDatosDeLaEmision);
        }
    }
}