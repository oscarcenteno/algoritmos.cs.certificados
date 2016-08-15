using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConParameterObject
{
    public class CertificadoDeFirma
    {
        private DatosParaUnCertificadoDigital losDatos;

        public CertificadoDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            losDatos = DetermineInformacionDeFirma(losDatosDeLaEmision);
            losDatos.Nombre = losDatosDeLaEmision.Nombre;
            losDatos.Identificacion = losDatosDeLaEmision.Identificacion;
            losDatos.PrimerApellido = losDatosDeLaEmision.PrimerApellido;
            losDatos.SegundoApellido = losDatosDeLaEmision.SegundoApellido;
            losDatos.FechaActual = losDatosDeLaEmision.FechaActual;
            losDatos.DireccionDeRevocacion = losDatosDeLaEmision.DireccionDeRevocacion;
            losDatos.AñosDeVigencia = losDatosDeLaEmision.AñosDeVigencia;
        }

        private static DatosParaUnCertificadoDigital DetermineInformacionDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            // TODO: Codigo que no cumple tell dont ask
            if (EsNacional(losDatosDeLaEmision))
                return new DatosParaUnCertificadoDigitalNacionalDeFirma();
            else
                return new DatosParaUnCertificadoDigitalExtranjeroDeFirma();
        }

        private static bool EsNacional(DatosDeLaEmision losDatosDeLaEmision)
        {
            // TODO: Mas de una operacion
            return losDatosDeLaEmision.TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(losDatos);
        }
    }
}