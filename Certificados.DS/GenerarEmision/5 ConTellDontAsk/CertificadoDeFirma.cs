using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConTellDontAsk
{
    public class CertificadoDeFirma
    {
        DatosParaUnCertificadoDigital losDatos;

        public CertificadoDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            losDatos = losDatosDeLaEmision.InformacionDeFirma;

            losDatos.Nombre = losDatosDeLaEmision.Nombre;
            losDatos.Identificacion = losDatosDeLaEmision.Identificacion;
            losDatos.PrimerApellido = losDatosDeLaEmision.PrimerApellido;
            losDatos.SegundoApellido = losDatosDeLaEmision.SegundoApellido;
            losDatos.FechaActual = losDatosDeLaEmision.FechaActual;
            losDatos.DireccionDeRevocacion = losDatosDeLaEmision.DireccionDeRevocacion;
            losDatos.AñosDeVigencia = losDatosDeLaEmision.AñosDeVigencia;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(losDatos);
        }
    }
}