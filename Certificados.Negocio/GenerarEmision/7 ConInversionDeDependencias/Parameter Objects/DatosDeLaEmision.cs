using System;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.Negocio.GenerarEmision.ConInversionDeDependencias
{
    public abstract class DatosDeLaEmision
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public abstract DatosParaUnCertificadoDigital DatosDeAutenticacion { get; }
        public abstract DatosParaUnCertificadoDigital DatosDeFirma { get; }

        public abstract int AñosDeVigencia { get; }
        public abstract string DireccionDeRevocacion { get; }
        public abstract DateTime FechaActual { get; }
    }
}