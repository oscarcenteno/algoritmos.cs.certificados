using System;

namespace Certificados.DS.RegistrarEmision
{
    public class RegistroDeEmision
    {
        public DateTime FechaDeGeneracion { get; set; }
        public RegistroDeCertificado CertificadoDeAutenticacion { get; set; }
        public RegistroDeCertificado CertificadoDeFirma { get; set; }
    }
}