using Sujetos;
using Certificados.Negocio.GenerarCertificados;

namespace Certificados.DS.GenerarEmision.ConTellDontAsk
{
    public class CertificadoDeFirma
    {
        private InformacionFormateada laInformacionDeFirma;

        public CertificadoDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            laInformacionDeFirma = GenereLaInformacionDeFirma(losDatosDeLaEmision);
        }

        private static InformacionFormateada GenereLaInformacionDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            InformacionFormateada laInformacionDeFirma = DetermineInformacionDeFirma(losDatosDeLaEmision);

            // TODO: Codigo procedimental.
            laInformacionDeFirma.Nombre = losDatosDeLaEmision.Nombre;
            laInformacionDeFirma.Identificacion = losDatosDeLaEmision.Identificacion;
            laInformacionDeFirma.PrimerApellido = losDatosDeLaEmision.PrimerApellido;
            laInformacionDeFirma.SegundoApellido = losDatosDeLaEmision.SegundoApellido;
            laInformacionDeFirma.FechaActual = losDatosDeLaEmision.FechaActual;
            laInformacionDeFirma.DireccionDeRevocacion = losDatosDeLaEmision.DireccionDeRevocacion;
            laInformacionDeFirma.AñosDeVigencia = losDatosDeLaEmision.AñosDeVigencia;

            return laInformacionDeFirma;
        }

        private static InformacionFormateada DetermineInformacionDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            return losDatosDeLaEmision.InformacionDeFirma;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeFirma);
        }
    }
}