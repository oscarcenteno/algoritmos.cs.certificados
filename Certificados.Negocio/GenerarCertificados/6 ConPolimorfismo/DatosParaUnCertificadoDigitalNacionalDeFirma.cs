using Sujetos;

namespace Certificados.Negocio.GenerarCertificados.ConPolimorfismo
{
    public class DatosParaUnCertificadoDigitalNacionalDeFirma : DatosParaUnCertificadoDigital
    {
        public override InformacionFormateada InformacionFormateada
        {
            get
            {
                return new InformacionNacionalDeFirma();
            }
        }
    }
}
