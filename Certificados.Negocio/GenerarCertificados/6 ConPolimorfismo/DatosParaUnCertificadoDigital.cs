using Sujetos;
using System;

namespace Certificados.Negocio.GenerarCertificados.ConPolimorfismo
{
    public abstract class DatosParaUnCertificadoDigital
    {
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Identificacion { get; set; }
        public string DireccionDeRevocacion { get; set; }
        public int AñosDeVigencia { get; set; }
        public DateTime FechaActual { get; set; }

        public DateTime FechaDeVencimiento
        {
            get
            {
                return FechaActual.AddYears(AñosDeVigencia);
            }
        }

        public abstract InformacionFormateada InformacionFormateada { get; }
    }
}