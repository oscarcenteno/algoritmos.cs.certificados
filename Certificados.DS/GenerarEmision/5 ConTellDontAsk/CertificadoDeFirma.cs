using Sujetos;
using Certificados.Negocio.GenerarCertificados;

namespace Certificados.DS.GenerarEmision.ConTellDontAsk
{
    public class CertificadoDeFirma
    {
        private InformacionFormateada laInformacionDeFirma;

        public CertificadoDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            laInformacionDeFirma = losDatosDeLaEmision.InformacionDeFirma;

            laInformacionDeFirma.Nombre = losDatosDeLaEmision.Nombre;
            laInformacionDeFirma.Identificacion = losDatosDeLaEmision.Identificacion;
            laInformacionDeFirma.PrimerApellido = losDatosDeLaEmision.PrimerApellido;
            laInformacionDeFirma.SegundoApellido = losDatosDeLaEmision.SegundoApellido;
            laInformacionDeFirma.FechaActual = losDatosDeLaEmision.FechaActual;
            laInformacionDeFirma.DireccionDeRevocacion = losDatosDeLaEmision.DireccionDeRevocacion;
            laInformacionDeFirma.AñosDeVigencia = losDatosDeLaEmision.AñosDeVigencia;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeFirma);
        }
    }
}