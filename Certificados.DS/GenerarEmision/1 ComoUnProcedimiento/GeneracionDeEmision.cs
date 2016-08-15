using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using System;

namespace Certificados.DS.GenerarEmision.ComoUnProcedimiento
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
            string laDireccionDeRevocacion = new RepositorioDeParametros().ObtengaLaDireccionDeRevocacion();
            int losAñosDeVigencia = new RepositorioDeParametros().ObtengaLosAñosDeVigencia();
            DateTime laFechaActual = DateTime.Now;

            // 1. Genere la fecha de generacion
            Emision laEmision = new Emision();
            laEmision.FechaDeGeneracion = laFechaActual;

            // 2. Genere el certificado de autenticacion
            DatosParaUnCertificadoDigital losDatosDeAutenticacion;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                losDatosDeAutenticacion = new DatosParaUnCertificadoDigitalNacionalDeAutenticacion();
            else
                losDatosDeAutenticacion = new DatosParaUnCertificadoDigitalExtranjeroDeAutenticacion();

            losDatosDeAutenticacion.Nombre = elNombre;
            losDatosDeAutenticacion.Identificacion = laIdentificacion;
            losDatosDeAutenticacion.PrimerApellido = elPrimerApellido;
            losDatosDeAutenticacion.SegundoApellido = elSegundoApellido;
            losDatosDeAutenticacion.FechaActual = laFechaActual;
            losDatosDeAutenticacion.DireccionDeRevocacion = laDireccionDeRevocacion;
            losDatosDeAutenticacion.AñosDeVigencia = losAñosDeVigencia;

            laEmision.CertificadoDeAutenticacion = new CertificadoDigital(losDatosDeAutenticacion);

            // 3. Genere el certificado de firma
            DatosParaUnCertificadoDigital losDatosDeFirma;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                losDatosDeFirma = new DatosParaUnCertificadoDigitalNacionalDeFirma();
            else
                losDatosDeFirma = new DatosParaUnCertificadoDigitalExtranjeroDeFirma();

            losDatosDeFirma.Nombre = elNombre;
            losDatosDeFirma.Identificacion = laIdentificacion;
            losDatosDeFirma.PrimerApellido = elPrimerApellido;
            losDatosDeFirma.SegundoApellido = elSegundoApellido;
            losDatosDeFirma.FechaActual = laFechaActual;
            losDatosDeFirma.DireccionDeRevocacion = laDireccionDeRevocacion;
            losDatosDeFirma.AñosDeVigencia = losAñosDeVigencia;

            laEmision.CertificadoDeFirma = new CertificadoDigital(losDatosDeFirma);

            return laEmision;
        }
    }
}