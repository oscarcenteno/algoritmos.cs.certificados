using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public partial class RegistroDeEmision
    {
        public RegistroDeEmision() { }

        public RegistroDeEmision(Emision laEmision)
        {
            FechaDeGeneracion = ObtengaLaFecha(laEmision);
            CertificadoDeAutenticacion = ObtengaElRegistroDeCertificadoDeAutenticacion(laEmision);
            CertificadoDeFirma = ObtengaElRegistroDeCertificadoDeFirma(laEmision);
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public DateTime FechaDeGeneracion { get; set; }
        public RegistroDeCertificado CertificadoDeAutenticacion { get; set; }
        public RegistroDeCertificado CertificadoDeFirma { get; set; }

        private static DateTime ObtengaLaFecha(Emision laEmision)
        {
            return laEmision.FechaDeGeneracion;
        }

        private static RegistroDeCertificado ObtengaElRegistroDeCertificadoDeAutenticacion(Emision laEmision)
        {
            return new RegistroDeCertificadoDeAutenticacion(laEmision).Mapeado();
        }

        private static RegistroDeCertificado ObtengaElRegistroDeCertificadoDeFirma(Emision laEmision)
        {
            return new RegistroDeCertificadoDeFirma(laEmision).Mapeado();
        }
    }
}