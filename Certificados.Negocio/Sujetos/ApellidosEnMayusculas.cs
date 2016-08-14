using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

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