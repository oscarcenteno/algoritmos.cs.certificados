using System;
using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConTellDontAsk
{
    public class DatosDeLaEmision
    {
        public TipoDeIdentificacion TipoDeIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public DatosParaUnCertificadoDigital InformacionDeAutenticacion
        {
            get
            {
                if (EsNacional())
                    return new DatosParaUnCertificadoDigitalNacionalDeAutenticacion();
                else
                    return new DatosParaUnCertificadoDigitalExtranjeroDeAutenticacion();
            }
        }

        private bool EsNacional()
        {
            return TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        public DatosParaUnCertificadoDigital InformacionDeFirma
        {
            get
            {
                if (EsNacional())
                    return new DatosParaUnCertificadoDigitalNacionalDeFirma();
                else
                    return new DatosParaUnCertificadoDigitalExtranjeroDeFirma();
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