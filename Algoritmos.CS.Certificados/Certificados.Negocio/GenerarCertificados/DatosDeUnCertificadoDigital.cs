using System;

namespace Certificados.Negocio.GenerarCertificados
{
    public class DatosDeUnCertificadoDigital
    {
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Identificacion { get; set; }
        public string DireccionDeRevocacion { get; set; }
        public int AñosDeVigencia { get; set; }
        public DateTime FechaActual { get; set; }

        public string NombreEnMayuscula
        {
            get
            {
                return Nombre.ToUpper();
            }
        }

        public string ApellidosUnidos
        {
            get
            {
                return $"{PrimerApellido} {SegundoApellido}";
            }
        }


        public DateTime FechaDeVencimiento
        {
            get
            {
                return FechaActual.AddYears(AñosDeVigencia);
            }
        }
    }
}