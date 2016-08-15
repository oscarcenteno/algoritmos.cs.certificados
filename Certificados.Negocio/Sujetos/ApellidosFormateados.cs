using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Sujetos
{
    public class ApellidosFormateados
    {
        string losApellidosEnMayusculas;

        public ApellidosFormateados(InformacionFormateada laInformacion)
        {
            losApellidosEnMayusculas = ObtengaLosApellidosEnMayusculas(laInformacion);
        }

        private static string ObtengaLosApellidosEnMayusculas(InformacionFormateada laInformacion)
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