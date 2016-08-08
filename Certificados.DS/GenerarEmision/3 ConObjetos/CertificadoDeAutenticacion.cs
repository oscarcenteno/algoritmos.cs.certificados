using System;
using Certificados.Negocio.GenerarCertificados;
using Sujetos;

namespace Certificados.DS.GenerarEmision.ConObjetos
{
    public class CertificadoDeAutenticacion
    {
        InformacionFormateada laInformacionDeAutenticacion;

        public CertificadoDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, string laDireccionDeRevocacion, int losAñosDeVigencia, DateTime laFechaActual)
        {
            laInformacionDeAutenticacion = DetermineInformacionDeAutenticacion(elTipoDeIdentificacion);

            laInformacionDeAutenticacion.Nombre = elNombre;
            laInformacionDeAutenticacion.Identificacion = laIdentificacion;
            laInformacionDeAutenticacion.PrimerApellido = elPrimerApellido;
            laInformacionDeAutenticacion.SegundoApellido = elSegundoApellido;
            laInformacionDeAutenticacion.FechaActual = laFechaActual;
            laInformacionDeAutenticacion.DireccionDeRevocacion = laDireccionDeRevocacion;
            laInformacionDeAutenticacion.AñosDeVigencia = losAñosDeVigencia;
        }

        private static InformacionFormateada DetermineInformacionDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return new InformacionNacionalDeAutenticacion();
            else
                return new InformacionExtranjeraDeAutenticacion();
        }

        private static bool EsNacional(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            return elTipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeAutenticacion);
        }
    }
}