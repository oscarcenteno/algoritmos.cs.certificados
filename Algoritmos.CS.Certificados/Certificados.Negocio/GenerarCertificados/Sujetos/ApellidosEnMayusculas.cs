using Certificados.Negocio.GenerarCertificados;

namespace Sujetos
{
    public class ApellidosEnMayusculas
    {
        private string losApellidos;

        public ApellidosEnMayusculas(DatosDeUnCertificadoDigital laInformacion)
        {
            losApellidos = laInformacion.ApellidosUnidos;
        }

        public string ComoTexto()
        {
            return losApellidos.ToUpper();
        }
    }
}