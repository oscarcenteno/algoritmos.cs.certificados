namespace Sujetos
{
    public class ApellidosEnMayusculas
    {
        private string losApellidos;

        public ApellidosEnMayusculas(InformacionDelSolicitante laInformacion)
        {
            losApellidos = laInformacion.ApellidosUnidos;
        }

        public string ComoTexto()
        {
            return losApellidos.ToUpper();
        }
    }
}