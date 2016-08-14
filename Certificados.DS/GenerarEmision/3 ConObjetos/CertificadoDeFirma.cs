using Sujetos;
using System;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConObjetos
{
    public class CertificadoDeFirma
    {
        private InformacionFormateada laInformacionDeFirma;

        public CertificadoDeFirma(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            laInformacionDeFirma = DetermineInformacionDeFirma(elTipoDeIdentificacion);

            laInformacionDeFirma.Nombre = elNombre;
            laInformacionDeFirma.Identificacion = laIdentificacion;
            laInformacionDeFirma.PrimerApellido = elPrimerApellido;
            laInformacionDeFirma.SegundoApellido = elSegundoApellido;
            laInformacionDeFirma.FechaActual = laFechaActual;
            laInformacionDeFirma.DireccionDeRevocacion = laDireccionDeRevocacion;
            laInformacionDeFirma.AñosDeVigencia = losAñosDeVigencia;
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