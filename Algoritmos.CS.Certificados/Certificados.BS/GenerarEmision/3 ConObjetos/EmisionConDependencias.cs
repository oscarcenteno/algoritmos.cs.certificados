using Certificados.DS.GenerarEmision;
using System;

namespace Certificados.BS.GenerarEmision.ConObjetos
{
    class EmisionConDependencias
    {
        private string laDireccionDeRevocacion;
        private int losAñosDeVigencia;
        private DateTime laFechaActual;
        private TipoDeIdentificacion elTipoDeIdentificacion;
        private string laIdentificacion;
        private string elNombre;
        private string elPrimerApellido;
        private string elSegundoApellido;

        public EmisionConDependencias(TipoDeIdentificacion elTipoDeIdentificacion, string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido)
        {
            this.elTipoDeIdentificacion = elTipoDeIdentificacion;
            this.laIdentificacion = laIdentificacion;
            this.elNombre = elNombre;
            this.elPrimerApellido = elPrimerApellido;
            this.elSegundoApellido = elSegundoApellido;

            // Las dependencias con recursos externos
            laDireccionDeRevocacion = ObtengaLaDireccionDeRevocacion();
            losAñosDeVigencia = ObtengaLosAnosDeVigencia();
            laFechaActual = ObtengaLaFechaActual();
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

        public Emision ComoObjeto()
        {
            return new Emision(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual);
        }
    }
}