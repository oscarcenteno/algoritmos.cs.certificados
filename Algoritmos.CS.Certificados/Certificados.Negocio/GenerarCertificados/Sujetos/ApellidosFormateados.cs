using Certificados.Negocio.GenerarCertificados;

namespace Sujetos
{
    public class ApellidosFormateados
    {
        string losApellidosEnMayusculas;

        public ApellidosFormateados(DatosDeUnCertificadoDigital laInformacion)
        {
            losApellidosEnMayusculas = ObtengaLosApellidosEnMayusculas(laInformacion);
        }

        private static string ObtengaLosApellidosEnMayusculas(DatosDeUnCertificadoDigital laInformacion)
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