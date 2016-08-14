using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Sujetos;

namespace Certificados.DS.GenerarEmision.ConParameterObject
{
    public class CertificadoDeAutenticacion
    {
        InformacionFormateada laInformacionDeAutenticacion;

        public CertificadoDeAutenticacion(DatosDeLaEmision losDatosDeLaEmision)
        {
            laInformacionDeAutenticacion = DetermineInformacionDeAutenticacion(losDatosDeLaEmision);
            laInformacionDeAutenticacion.Nombre = losDatosDeLaEmision.Nombre;
            laInformacionDeAutenticacion.Identificacion = losDatosDeLaEmision.Identificacion;
            laInformacionDeAutenticacion.PrimerApellido = losDatosDeLaEmision.PrimerApellido;
            laInformacionDeAutenticacion.SegundoApellido = losDatosDeLaEmision.SegundoApellido;
            laInformacionDeAutenticacion.FechaActual = losDatosDeLaEmision.FechaActual;
            laInformacionDeAutenticacion.DireccionDeRevocacion = losDatosDeLaEmision.DireccionDeRevocacion;
            laInformacionDeAutenticacion.AñosDeVigencia = losDatosDeLaEmision.AñosDeVigencia;

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