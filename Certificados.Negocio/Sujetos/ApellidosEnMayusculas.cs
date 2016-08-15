using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Sujetos
{
    public class ApellidosEnMayusculas
    {
        private string losApellidos;

        public ApellidosEnMayusculas(InformacionFormateada laInformacion)
        {
            losApellidos = laInformacion.ApellidosUnidos;
        }

        public string ComoTexto()
        {
            return losApellidos.ToUpper();
        }
    }
}