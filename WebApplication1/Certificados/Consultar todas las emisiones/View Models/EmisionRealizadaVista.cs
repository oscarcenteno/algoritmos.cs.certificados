using System;
using System.ComponentModel;

namespace WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels
{
    public class EmisionRealizadaVista
    {
        public int ID { get;  set; }

        public string IDComoTexto
        {
            get
            {
                return ID.ToString();
            }
        }

        [DisplayName("Fecha de generacion")]
        public DateTime FechaDeGeneracion { get; set; }
    }
}