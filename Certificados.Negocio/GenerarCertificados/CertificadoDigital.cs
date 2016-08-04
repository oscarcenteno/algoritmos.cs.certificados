using System;
using Sujetos;

namespace Certificados.Negocio.GenerarCertificados
{
    public class CertificadoDigital
    {
        private InformacionFormateada laInformacion;

        public CertificadoDigital(InformacionFormateada laInformacion)
        {
            this.laInformacion = laInformacion;
        }

        public string Sujeto
        {
            get
            {
                return new SujetoFormateado(laInformacion).ComoTexto();
            }
        }

        public DateTime FechaDeEmision
        {
            get
            {
                return laInformacion.FechaActual;
            }
        }

        public DateTime FechaDeVencimiento
        {
            get
            {
                return laInformacion.FechaDeVencimiento;
            }
        }

        public string DireccionDeRevocacion
        {
            get
            {
                return laInformacion.DireccionDeRevocacion;
            }
        }
    }
}