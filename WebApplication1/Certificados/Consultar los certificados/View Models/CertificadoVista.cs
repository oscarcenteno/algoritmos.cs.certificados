using System;
using System.ComponentModel;

namespace WebApplication1.Certificados.ConsultarLosCertificados.ViewModels
{
    public class CertificadoVista
    {
        public DateTime FechaDeEmision { get; set; }

        [DisplayName("Fecha de emisión")]
        public string FechaDeEmisionFormateada
        {
            get
            {
                return FechaDeEmision.ToString("yyyy-MM-dd");
            }
        }

        public DateTime FechaDeVencimiento { get; set; }

        [DisplayName("Fecha de vencimiento")]
        public string FechaDeVencimientoFormateada
        {
            get
            {
                return FechaDeVencimiento.ToString("yyyy-MM-dd");
            }
        }

        public string Sujeto { get; set; }

        public string DireccionDeRevocacion { get; set; }
    }
}