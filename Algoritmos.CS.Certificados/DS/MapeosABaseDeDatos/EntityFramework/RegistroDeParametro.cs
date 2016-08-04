using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class RegistroDeParametro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Valor { get; set; }

        [Required]
        public DateTime FechaDeRegistro { get; set; }
    }
}