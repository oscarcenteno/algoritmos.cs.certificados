namespace Sujetos
{
    public class ApellidosFormateados
    {
        string losApellidosEnMayusculas;

        public ApellidosFormateados(InformacionDelSolicitante laInformacion)
        {
            losApellidosEnMayusculas = ObtengaLosApellidosEnMayusculas(laInformacion);
        }

        private static string ObtengaLosApellidosEnMayusculas(InformacionDelSolicitante laInformacion)
        {
            return new ApellidosEnMayusculas(laInformacion).ComoTexto();
        }

        public string ComoTexto()
        {
            return ElimineLosEspaciosAlFinal(losApellidosEnMayusculas);
        }

        private static string ElimineLosEspaciosAlFinal(string losApellidosEnMayusculas)
        {
            return losApellidosEnMayusculas.TrimEnd();
        }
    }
}