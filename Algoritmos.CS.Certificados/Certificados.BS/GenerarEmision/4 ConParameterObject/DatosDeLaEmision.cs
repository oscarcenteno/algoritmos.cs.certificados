using System;

namespace Certificados.BS.GenerarEmision.ConParameterObject
{
    public class DatosDeLaEmision
    {
        public int AñosDeVigencia { get; internal set; }
        public string DireccionDeRevocacion { get; internal set; }
        public DateTime FechaActual { get; internal set; }

        public TipoDeIdentificacion TipoDeIdentificacion { get; internal set; }
        public string Identificacion { get; internal set; }
        public string Nombre { get; internal set; }
        public string PrimerApellido { get; internal set; }
        public string SegundoApellido { get; internal set; }
    }
}