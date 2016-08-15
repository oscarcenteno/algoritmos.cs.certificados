using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using System;

namespace Certificados.DS.GenerarEmision.ConObjetos
{
    public class Emision
    {
        private TipoDeIdentificacion elTipoDeIdentificacion;
        private string laIdentificacion;
        private string elNombre;
        private string elPrimerApellido;
        private string elSegundoApellido;
        private string laDireccionDeRevocacion;
        private int losAñosDeVigencia;
        private DateTime laFechaActual;

        public Emision(TipoDeIdentificacion elTipoDeIdentificacion, 
            string laIdentificacion, 
            string elNombre, 
            string elPrimerApellido, 
            string elSegundoApellido, 
            string laDireccionDeRevocacion, 
            int losAñosDeVigencia, 
            DateTime laFechaActual)
        {
            this.elTipoDeIdentificacion = elTipoDeIdentificacion;
            this.laIdentificacion = laIdentificacion;
            this.elNombre = elNombre;
            this.elPrimerApellido = elPrimerApellido;
            this.elSegundoApellido = elSegundoApellido;
            this.laDireccionDeRevocacion = laDireccionDeRevocacion;
            this.losAñosDeVigencia = losAñosDeVigencia;
            this.laFechaActual = laFechaActual;
        }

        public DateTime FechaDeGeneracion
        {
            get
            {
                return laFechaActual;
            }
        }

        public CertificadoDigital CertificadoDeAutenticacion
        {
            get
            {
                return new CertificadoDeAutenticacion(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual).Generado();
            }
        }

        public CertificadoDigital CertificadoDeFirma
        {
            get
            {
                return new CertificadoDeFirma(elTipoDeIdentificacion, laIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, laDireccionDeRevocacion, losAñosDeVigencia, laFechaActual).Generado();
            }
        }
    }
}