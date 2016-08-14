using Sujetos;
using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConParameterObject
{
    public class CertificadoDeFirma
    {
        private InformacionFormateada laInformacionDeFirma;

        public CertificadoDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            laInformacionDeFirma = DetermineInformacionDeFirma(losDatosDeLaEmision);
            laInformacionDeFirma.Nombre = losDatosDeLaEmision.Nombre;
            laInformacionDeFirma.Identificacion = losDatosDeLaEmision.Identificacion;
            laInformacionDeFirma.PrimerApellido = losDatosDeLaEmision.PrimerApellido;
            laInformacionDeFirma.SegundoApellido = losDatosDeLaEmision.SegundoApellido;
            laInformacionDeFirma.FechaActual = losDatosDeLaEmision.FechaActual;
            laInformacionDeFirma.DireccionDeRevocacion = losDatosDeLaEmision.DireccionDeRevocacion;
            laInformacionDeFirma.AñosDeVigencia = losDatosDeLaEmision.AñosDeVigencia;
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