using System;
using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
{
    public abstract class DatosDeLaEmision
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public abstract DatosParaUnCertificadoDigital DatosDeAutenticacion { get; }

        public abstract DatosParaUnCertificadoDigital DatosDeFirma { get; }

        public int AñosDeVigencia
        {
            get
            {
                return new RepositorioDeParametros().ObtengaLosAñosDeVigencia();
            }
        }

        public string DireccionDeRevocacion
        {
            get
            {
                return new RepositorioDeParametros().ObtengaLaDireccionDeRevocacion();
            }
        }

        public DateTime FechaActual
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}