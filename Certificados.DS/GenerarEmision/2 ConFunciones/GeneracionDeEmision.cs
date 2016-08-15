using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
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
            DatosParaUnCertificadoDigital losDatos;
            losDatos = GenereLaInformacionDeAutenticacion(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);

            return new CertificadoDigital(losDatos);
        }

        private static DatosParaUnCertificadoDigital GenereLaInformacionDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            DatosParaUnCertificadoDigital losDatos;
            losDatos = DetermineInformacionDeAutenticacion(elTipoDeIdentificacion);

            losDatos.Nombre = elNombre;
            losDatos.Identificacion = laIdentificacion;
            losDatos.PrimerApellido = elPrimerApellido;
            losDatos.SegundoApellido = elSegundoApellido;
            losDatos.FechaActual = laFechaActual;
            losDatos.DireccionDeRevocacion = laDireccionDeRevocacion;
            losDatos.AñosDeVigencia = losAñosDeVigencia;

            return losDatos;
        }

        private static DatosParaUnCertificadoDigital DetermineInformacionDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return new DatosParaUnCertificadoDigitalNacionalDeAutenticacion();
            else
                return new DatosParaUnCertificadoDigitalExtranjeroDeAutenticacion();
        }

        private static CertificadoDigital ObtengaElCertificadoDeFirma(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            DatosParaUnCertificadoDigital laInformacionDeFirma = GenereLaInformacionDeFirma(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);

            return new CertificadoDigital(laInformacionDeFirma);
        }

        private static DatosParaUnCertificadoDigital GenereLaInformacionDeFirma(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            DatosParaUnCertificadoDigital losDatos;
            losDatos = DetermineInformacionDeFirma(elTipoDeIdentificacion);

            losDatos.Nombre = elNombre;
            losDatos.Identificacion = laIdentificacion;
            losDatos.PrimerApellido = elPrimerApellido;
            losDatos.SegundoApellido = elSegundoApellido;
            losDatos.FechaActual = laFechaActual;
            losDatos.DireccionDeRevocacion = laDireccionDeRevocacion;
            losDatos.AñosDeVigencia = losAñosDeVigencia;

            return losDatos;
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
    }
}