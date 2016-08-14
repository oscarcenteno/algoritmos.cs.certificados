using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using System;

namespace Certificados.DS.GenerarEmision.ConObjetos
{
    public class Emision
    {
        private DateTime laFechaActual;
        private CertificadoDigital elCertificadoDeAutenticacion;
        private CertificadoDigital elCertificadoDeFirma;

        public Emision(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            this.laFechaActual = laFechaActual;
            elCertificadoDeAutenticacion = ObtengaElCertificadoDeAutenticacion(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);
            elCertificadoDeFirma = ObtengaElCertificadoDeFirma(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);
        }

        private static CertificadoDigital ObtengaElCertificadoDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            return new CertificadoDeAutenticacion(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual).Generado();
        }

        private static CertificadoDigital ObtengaElCertificadoDeFirma(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            return new CertificadoDeFirma(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual).Generado();
        }

        public DateTime FechaDeGeneracion
        {
            get { return laFechaActual; }
        }

        public CertificadoDigital CertificadoDeAutenticacion
        {
            get { return elCertificadoDeAutenticacion; }
        }

        public CertificadoDigital CertificadoDeFirma
        {
            get { return elCertificadoDeFirma; }
        }
    }
}