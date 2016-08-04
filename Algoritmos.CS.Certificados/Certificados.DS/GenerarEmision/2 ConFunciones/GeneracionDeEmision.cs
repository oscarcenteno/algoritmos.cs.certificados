using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarCertificados;
using Sujetos;
using System;

namespace Certificados.DS.GenerarEmision.ConFunciones
{
    public static class GeneracionDeEmision
    {
        public static Emision GenereLaEmision(TipoDeIdentificacion elTipoDeIdentificacion,
            string laIdentificacion,
            string elNombre,
            string elPrimerApellido,
            string elSegundoApellido)
        {
            // Las dependencias con recursos externos
            string laDireccionDeRevocacion = ObtengaLaDireccionDeRevocacion();
            int losAñosDeVigencia = ObtengaLosAnosDeVigencia();
            DateTime laFechaActual = ObtengaLaFechaActual();

            return ObtengaLaEmision(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);
        }

        private static string ObtengaLaDireccionDeRevocacion()
        {
            return new RepositorioDeParametros().ObtengaLaDireccionDeRevocacion();
        }

        private static int ObtengaLosAnosDeVigencia()
        {
            return new RepositorioDeParametros().ObtengaLosAñosDeVigencia();
        }

        private static DateTime ObtengaLaFechaActual()
        {
            return DateTime.Now;
        }

        private static Emision ObtengaLaEmision(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            Emision laEmision = new Emision();
            laEmision.FechaDeGeneracion = laFechaActual;
            laEmision.CertificadoDeAutenticacion = ObtengaElCertificadoDeAutenticacion(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);
            laEmision.CertificadoDeFirma = ObtengaElCertificadoDeFirma(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);

            return laEmision;
        }

        private static CertificadoDigital ObtengaElCertificadoDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            InformacionFormateada laInformacionDeAutenticacion;
            laInformacionDeAutenticacion = GenereLaInformacionDeAutenticacion(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laFechaActual);

            return new CertificadoDigital(laInformacionDeAutenticacion);
        }

        private static InformacionFormateada GenereLaInformacionDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, DateTime laFechaActual)
        {
            InformacionFormateada laInformacionDeAutenticacion;
            laInformacionDeAutenticacion = DetermineInformacionDeAutenticacion(elTipoDeIdentificacion);

            laInformacionDeAutenticacion.Nombre = elNombre;
            laInformacionDeAutenticacion.Identificacion = laIdentificacion;
            laInformacionDeAutenticacion.PrimerApellido = elPrimerApellido;
            laInformacionDeAutenticacion.SegundoApellido = elSegundoApellido;
            laInformacionDeAutenticacion.FechaActual = laFechaActual;

            return laInformacionDeAutenticacion;
        }

        private static InformacionFormateada DetermineInformacionDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return new InformacionNacionalDeAutenticacion();
            else
                return new InformacionExtranjeraDeAutenticacion();
        }

        private static CertificadoDigital ObtengaElCertificadoDeFirma(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            InformacionFormateada laInformacionDeFirma = GenereLaInformacionDeFirma(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);

            return new CertificadoDigital(laInformacionDeFirma);
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
    }
}