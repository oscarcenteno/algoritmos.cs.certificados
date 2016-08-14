using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Sujetos;

namespace Certificados.DS.GenerarEmision.ConTellDontAsk
{
    public class CertificadoDeAutenticacion
    {
        InformacionFormateada laInformacionDeAutenticacion;

        public CertificadoDeAutenticacion(DatosDeLaEmision losDatosDeLaEmision)
        {
            laInformacionDeAutenticacion = losDatosDeLaEmision.InformacionDeAutenticacion;

            laInformacionDeAutenticacion.Nombre = losDatosDeLaEmision.Nombre;
            laInformacionDeAutenticacion.Identificacion = losDatosDeLaEmision.Identificacion;
            laInformacionDeAutenticacion.PrimerApellido = losDatosDeLaEmision.PrimerApellido;
            laInformacionDeAutenticacion.SegundoApellido = losDatosDeLaEmision.SegundoApellido;
            laInformacionDeAutenticacion.FechaActual = losDatosDeLaEmision.FechaActual;
            laInformacionDeAutenticacion.DireccionDeRevocacion = losDatosDeLaEmision.DireccionDeRevocacion;
            laInformacionDeAutenticacion.AñosDeVigencia = losDatosDeLaEmision.AñosDeVigencia;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeAutenticacion);
        }
    }
}