using Sujetos;

namespace Certificados.Negocio.GenerarCertificados.ConPolimorfismo
{
    public class DatosParaUnCertificadoDigitalExtranjeroDeAutenticacion : DatosParaUnCertificadoDigital
    {
        public override InformacionFormateada InformacionFormateada
        {
            get
            {
                return new InformacionExtranjeraDeAutenticacion();
            }
        }
    }
}
