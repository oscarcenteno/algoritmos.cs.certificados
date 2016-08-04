using Certificados.Negocio.GenerarCertificados;
using Sujetos;

namespace Certificados.DS.GenerarEmision.ConParameterObject
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
            // TODO: Codigo procedimental. Se arreglara con tell dont ask
            InformacionFormateada laInformacionDeAutenticacion = DetermineInformacionDeAutenticacion(losDatosDeLaEmision);
            laInformacionDeAutenticacion.Nombre = losDatosDeLaEmision.Nombre;
            laInformacionDeAutenticacion.Identificacion = losDatosDeLaEmision.Identificacion;
            laInformacionDeAutenticacion.PrimerApellido = losDatosDeLaEmision.PrimerApellido;
            laInformacionDeAutenticacion.SegundoApellido = losDatosDeLaEmision.SegundoApellido;
            laInformacionDeAutenticacion.FechaActual = losDatosDeLaEmision.FechaActual;

            return laInformacionDeAutenticacion;
        }

        private static InformacionFormateada DetermineInformacionDeAutenticacion(DatosDeLaEmision losDatosDeLaEmision)
        {
            // TODO: Codigo que no cumple tell dont ask
            if (EsNacional(losDatosDeLaEmision))
                return new InformacionNacionalDeAutenticacion();
            else
                return new InformacionExtranjeraDeAutenticacion();
        }

        private static bool EsNacional(DatosDeLaEmision losDatosDeLaEmision)
        {
            // TODO: Mas de una operacion
            return losDatosDeLaEmision.TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeAutenticacion);
        }
    }
}