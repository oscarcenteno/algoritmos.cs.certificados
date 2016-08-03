using Sujetos;
using Certificados.Negocio.GenerarCertificados;

namespace Certificados.BS.GenerarEmision.ConParameterObject
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

            // TODO: Codigo procedimental. Se arreglara con tell dont ask
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
            // TODO: Codigo que no cumple tell dont ask
            if (EsNacional(losDatosDeLaEmision))
                return new InformacionNacionalDeFirma();
            else
                return new InformacionExtranjeraDeFirma();
        }

        private static bool EsNacional(DatosDeLaEmision losDatosDeLaEmision)
        {
            // TODO: Mas de una operacion
            return losDatosDeLaEmision.TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeFirma);
        }
    }
}