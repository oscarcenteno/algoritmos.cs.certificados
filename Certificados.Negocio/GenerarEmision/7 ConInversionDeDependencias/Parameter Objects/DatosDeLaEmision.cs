using System;
using Sujetos;

namespace Certificados.Negocio.GenerarEmision.ConInversionDeDependencias
{
    public abstract class DatosDeLaEmision
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public abstract InformacionFormateada InformacionDeAutenticacion { get; }
        public abstract InformacionFormateada InformacionDeFirma { get; }

        public abstract int AñosDeVigencia { get; }
        public abstract string DireccionDeRevocacion { get; }
        public abstract DateTime FechaActual { get; }
    }
}