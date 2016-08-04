using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class RegistroDeCertificado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Sujeto { get; set; }
        [Required]
        public DateTime FechaDeEmision { get; set; }
        [Required]
        public DateTime FechaDeVencimiento { get; set; }
        [Required]
        public string DireccionDeRevocacion { get; set; }
    }
}