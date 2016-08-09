using Certificados.DS.MapeosABaseDeDatos;
using Mapeable;
using System.Collections.Generic;
using System;

namespace WebApplication1.Certificados.ConsultarLosCertificados.ViewModels
{
    public class MapeoACertificadosVista 
    {
        List<CertificadoVista> laLista = new List<CertificadoVista>();

        public MapeoACertificadosVista(RegistroDeEmision laEmision)
        {
            var elCertificadoDeAutenticacion = laEmision.CertificadoDeAutenticacion;
            CertificadoVista elDeAutenticacion;
            elDeAutenticacion = new Mapeo<RegistroDeCertificado, CertificadoVista>().Mapee(elCertificadoDeAutenticacion);
            laLista.Add(elDeAutenticacion);

            var elCertificadoDeFirma = laEmision.CertificadoDeFirma;
            CertificadoVista elDeFirma;
            elDeFirma = new Mapeo<RegistroDeCertificado, CertificadoVista>().Mapee(elCertificadoDeFirma);
            laLista.Add(elDeFirma);
        }

        public List<CertificadoVista> ComoLista()
        {
            return laLista;
        }
    }
}