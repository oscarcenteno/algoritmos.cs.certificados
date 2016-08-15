using System;
using Sujetos;

namespace Certificados.Negocio.GenerarCertificados.ConTellDontAsk
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

        public DateTime FechaDeVencimiento
        {
            get
            {
                return FechaActual.AddYears(AñosDeVigencia);
            }
        }

        public InformacionFormateada InformacionDeAutenticaicon
        {
            get
            {
                if (EsNacional())
                    return new InformacionNacionalDeAutenticacion();
                else
                    return new InformacionExtranjeraDeAutenticacion();
            }
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

        public InformacionFormateada InformacionFormateada
        {
            get
            {
                if (ElPropositoEsDeAutenticacion())
                    return InformacionDeAutenticaicon;
                else
                    return InformacionDeFirma;
            }
        }

        internal bool ElPropositoEsDeAutenticacion()
        {
            return TipoDeCertificado == TipoDeCertificado.Autenticacion;
        }

        internal bool EsNacional()
        {
            return TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }
    }
}