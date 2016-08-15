using System;

namespace Certificados.Negocio.GenerarCertificados.ConPolimorfismo
{
    public class CertificadoDigital
    {
        private DatosParaUnCertificadoDigital losDatos;

        public CertificadoDigital(DatosParaUnCertificadoDigital losDatos)
        {
            this.losDatos = losDatos;
        }

        public string Sujeto
        {
            get
            {
                return new Sujeto(losDatos).ComoTexto();
            }
        }

        public DateTime FechaDeEmision
        {
            get
            {
                return losDatos.FechaActual;
            }
        }

        public DateTime FechaDeVencimiento
        {
            get
            {
                return losDatos.FechaDeVencimiento;
            }
        }

        public string DireccionDeRevocacion
        {
            get
            {
                return losDatos.DireccionDeRevocacion;
            }
        }
    }
}