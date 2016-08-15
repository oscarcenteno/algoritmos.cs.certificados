using System;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConObjetos
{
    public class CertificadoDeFirma
    {
        private DatosParaUnCertificadoDigital losDatos;

        public CertificadoDeFirma(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            losDatos = DetermineInformacionDeFirma(elTipoDeIdentificacion);

            losDatos.Nombre = elNombre;
            losDatos.Identificacion = laIdentificacion;
            losDatos.PrimerApellido = elPrimerApellido;
            losDatos.SegundoApellido = elSegundoApellido;
            losDatos.FechaActual = laFechaActual;
            losDatos.DireccionDeRevocacion = laDireccionDeRevocacion;
            losDatos.AñosDeVigencia = losAñosDeVigencia;
        }

        private static DatosParaUnCertificadoDigital DetermineInformacionDeFirma(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return new DatosParaUnCertificadoDigitalNacionalDeFirma();
            else
                return new DatosParaUnCertificadoDigitalExtranjeroDeFirma();
        }

        private static bool EsNacional(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            return elTipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(losDatos);
        }
    }
}