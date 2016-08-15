using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using System;

namespace Certificados.DS.GenerarEmision.ConTellDontAsk
{
    public class Emision
    {
        DatosDeLaEmision losDatos;

        public Emision(DatosDeLaEmision losDatos)
        {
            this.losDatos = losDatos;
        }

        public DateTime FechaDeGeneracion
        {
            get
            {
                return losDatos.FechaActual;
            }
        }

        public CertificadoDigital CertificadoDeAutenticacion
        {
            get
            {
                return new CertificadoDeAutenticacion(losDatos).Generado();
            }
        }

        public CertificadoDigital CertificadoDeFirma
        {
            get
            {
                return new CertificadoDeFirma(losDatos).Generado();
            }
        }
    }
}