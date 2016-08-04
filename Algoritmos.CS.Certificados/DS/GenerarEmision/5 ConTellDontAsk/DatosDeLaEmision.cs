using System;
using Sujetos;
using Certificados.DS.MapeosABaseDeDatos;

namespace Certificados.DS.GenerarEmision.ConTellDontAsk
{
    public class DatosDeLaEmision
    {
        public TipoDeIdentificacion TipoDeIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public InformacionFormateada InformacionDeAutenticacion
        {
            get
            {
                if (EsNacional())
                    return new InformacionNacionalDeAutenticacion();
                else
                    return new InformacionExtranjeraDeAutenticacion();
            }
        }

        private bool EsNacional()
        {
            return TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        public InformacionFormateada InformacionDeFirma
        {
            get
            {
                if (EsNacional())
                    return new InformacionNacionalDeFirma();
                else
                    return new InformacionExtranjeraDeFirma();
            }
        }

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