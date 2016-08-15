using Sujetos;

namespace Certificados.Negocio.GenerarCertificados.ConPolimorfismo
{
    public class DatosParaUnCertificadoDigitalExtranjeroDeFirma : DatosParaUnCertificadoDigital
    {
        public override InformacionFormateada InformacionFormateada
        {
            get
            {
                return new InformacionExtranjeraDeFirma();
            }
        }
    }
}
