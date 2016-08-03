using Sujetos;
using System;
using Certificados.Negocio.GenerarCertificados;

namespace Certificados.DS.GenerarEmision.ConObjetos
{
    public class CertificadoDeFirma
    {
        private InformacionFormateada laInformacionDeFirma;

        public CertificadoDeFirma(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            laInformacionDeFirma = GenereLaInformacionDeFirma(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);
        }

        private static InformacionFormateada GenereLaInformacionDeFirma(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            InformacionFormateada laInformacionDeFirma;
            laInformacionDeFirma = DetermineInformacionDeFirma(elTipoDeIdentificacion);

            laInformacionDeFirma.Nombre = elNombre;
            laInformacionDeFirma.Identificacion = laIdentificacion;
            laInformacionDeFirma.PrimerApellido = elPrimerApellido;
            laInformacionDeFirma.SegundoApellido = elSegundoApellido;
            laInformacionDeFirma.FechaActual = laFechaActual;
            laInformacionDeFirma.DireccionDeRevocacion = laDireccionDeRevocacion;
            laInformacionDeFirma.AñosDeVigencia = losAñosDeVigencia;

            return laInformacionDeFirma;
        }

        private static InformacionFormateada DetermineInformacionDeFirma(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return new InformacionNacionalDeFirma();
            else
                return new InformacionExtranjeraDeFirma();
        }

        private static bool EsNacional(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            return elTipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeFirma);
        }
    }
}