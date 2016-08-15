using System;

namespace Certificados.Negocio.GenerarCertificados.ConParameterObject
{
    public class DatosParaUnCertificadoDigital
    {
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Identificacion { get; set; }
        public TipoDeIdentificacion TipoDeIdentificacion { get; set; }
        public TipoDeCertificado TipoDeCertificado { get; set; }
        public string DireccionDeRevocacion { get; set; }
        public int AñosDeVigencia { get; set; }
        public DateTime FechaActual { get; set; }
    }
}