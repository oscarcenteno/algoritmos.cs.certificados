using System;
using Sujetos;
using Certificados.DS.GenerarEmision;

namespace Certificados.BS.GenerarEmision.ConPolimorfismo
{
    public abstract class DatosDeLaEmision
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public abstract InformacionFormateada InformacionDeAutenticacion { get; }

        public abstract InformacionFormateada InformacionDeFirma { get; }

        public int AñosDeVigencia
        {
            get
            {
                return new RepositorioDeParametros().ObtengaLosAñosDeVigencia();
            }
        }

        public string DireccionDeRevocacion
        {
            get
            {
                return new RepositorioDeParametros().ObtengaLaDireccionDeRevocacion();
            }
        }

        public DateTime FechaActual
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}