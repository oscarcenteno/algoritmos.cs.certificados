using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarCertificados;
using Sujetos;
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
            InformacionFormateada laInformacionDeAutenticacion;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                laInformacionDeAutenticacion = new InformacionNacionalDeAutenticacion();
            else
                laInformacionDeAutenticacion = new InformacionExtranjeraDeAutenticacion();

            laInformacionDeAutenticacion.Nombre = elNombre;
            laInformacionDeAutenticacion.Identificacion = laIdentificacion;
            laInformacionDeAutenticacion.PrimerApellido = elPrimerApellido;
            laInformacionDeAutenticacion.SegundoApellido = elSegundoApellido;
            laInformacionDeAutenticacion.FechaActual = laFechaActual;
            laInformacionDeAutenticacion.DireccionDeRevocacion = laDireccionDeRevocacion;
            laInformacionDeAutenticacion.AñosDeVigencia = losAñosDeVigencia;

            laEmision.CertificadoDeAutenticacion = new CertificadoDigital(laInformacionDeAutenticacion);

            // 3. Genere el certificado de firma
            InformacionFormateada laInformacionDeFirma;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                laInformacionDeFirma = new InformacionNacionalDeFirma();
            else
                laInformacionDeFirma = new InformacionExtranjeraDeFirma();

            laInformacionDeFirma.Nombre = elNombre;
            laInformacionDeFirma.Identificacion = laIdentificacion;
            laInformacionDeFirma.PrimerApellido = elPrimerApellido;
            laInformacionDeFirma.SegundoApellido = elSegundoApellido;
            laInformacionDeFirma.FechaActual = laFechaActual;
            laInformacionDeFirma.DireccionDeRevocacion = laDireccionDeRevocacion;
            laInformacionDeFirma.AñosDeVigencia = losAñosDeVigencia;

            laEmision.CertificadoDeFirma = new CertificadoDigital(laInformacionDeFirma);

            return laEmision;
        }
    }
}