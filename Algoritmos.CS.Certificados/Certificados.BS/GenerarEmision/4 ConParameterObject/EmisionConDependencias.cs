using Certificados.DS.GenerarEmision;
using System;

namespace Certificados.BS.GenerarEmision.ConParameterObject
{
    class EmisionConDependencias
    {
        private DatosDeLaEmision losDatosDeLaEmision;

        public EmisionConDependencias(DatosDelSolicitante losDatosDelSolicitante)
        {
            losDatosDeLaEmision = new DatosDeLaEmision();
            losDatosDeLaEmision.TipoDeIdentificacion = losDatosDelSolicitante.TipoDeIdentificacion;
            losDatosDeLaEmision.Identificacion = losDatosDelSolicitante.Identificacion;
            losDatosDeLaEmision.Nombre = losDatosDelSolicitante.Nombre;
            losDatosDeLaEmision.PrimerApellido = losDatosDelSolicitante.PrimerApellido;
            losDatosDeLaEmision.SegundoApellido = losDatosDelSolicitante.SegundoApellido;

            // Las dependencias con recursos externos
            losDatosDeLaEmision.DireccionDeRevocacion = ObtengaLaDireccionDeRevocacion();
            losDatosDeLaEmision.AñosDeVigencia = ObtengaLosAnosDeVigencia();
            losDatosDeLaEmision.FechaActual = ObtengaLaFechaActual();
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
            return new Emision(losDatosDeLaEmision);
        }
    }
}