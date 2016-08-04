using Certificados.Negocio.GenerarCertificados;
using Sujetos;

namespace Certificados.DS.GenerarEmision.ConTellDontAsk
{
    public class CertificadoDeAutenticacion
    {
        InformacionFormateada laInformacionDeAutenticacion;

        public CertificadoDeAutenticacion(DatosDeLaEmision losDatosDeLaEmision)
        {
            laInformacionDeAutenticacion = GenereLaInformacionDeAutenticacion(losDatosDeLaEmision);
        }

        private static InformacionFormateada GenereLaInformacionDeAutenticacion(DatosDeLaEmision losDatosDeLaEmision)
        {
            InformacionFormateada laInformacionDeAutenticacion = DetermineInformacionDeAutenticacion(losDatosDeLaEmision);

            // TODO: Codigo procedimental.
            laInformacionDeAutenticacion.Nombre = losDatosDeLaEmision.Nombre;
            laInformacionDeAutenticacion.Identificacion = losDatosDeLaEmision.Identificacion;
            laInformacionDeAutenticacion.PrimerApellido = losDatosDeLaEmision.PrimerApellido;
            laInformacionDeAutenticacion.SegundoApellido = losDatosDeLaEmision.SegundoApellido;
            laInformacionDeAutenticacion.FechaActual = losDatosDeLaEmision.FechaActual;
            laInformacionDeAutenticacion.DireccionDeRevocacion = losDatosDeLaEmision.DireccionDeRevocacion;
            laInformacionDeAutenticacion.AñosDeVigencia = losDatosDeLaEmision.AñosDeVigencia;

            return laInformacionDeAutenticacion;
        }

        private static InformacionFormateada DetermineInformacionDeAutenticacion(DatosDeLaEmision losDatosDeLaEmision)
        {
            return losDatosDeLaEmision.InformacionDeAutenticacion;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeAutenticacion);
        }
    }
}