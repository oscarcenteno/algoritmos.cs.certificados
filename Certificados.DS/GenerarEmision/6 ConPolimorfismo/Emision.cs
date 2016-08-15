using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using System;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
{
    public class Emision
    {
        private DatosDeLaEmision losDatosDeLaEmision;

        public Emision(DatosDeLaEmision losDatosDeLaEmision)
        {
            this.losDatosDeLaEmision = losDatosDeLaEmision;
        }

        public DateTime FechaDeGeneracion
        {
            get
            {
                return losDatosDeLaEmision.FechaActual;
            }
        }

        public CertificadoDigital CertificadoDeAutenticacion
        {
            get
            {
                return new CertificadoDeAutenticacion(losDatosDeLaEmision).Generado();
            }
        }

        public CertificadoDigital CertificadoDeFirma
        {
            get
            {
                return new CertificadoDeFirma(losDatosDeLaEmision).Generado();
            }
        }
    }
}