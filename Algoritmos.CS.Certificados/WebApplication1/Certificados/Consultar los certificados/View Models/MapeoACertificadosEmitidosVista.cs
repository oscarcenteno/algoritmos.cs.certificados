using Certificados.DS.MapeosABaseDeDatos;
using Mapeable;
using System.Collections.Generic;

namespace WebApplication1.Certificados.ConsultarLosCertificados.ViewModels
{
    public static class MapeoACertificadosEmitidosVista
    {
        public static List<CertificadoEmitidoVista> Mapee(RegistroDeEmision laEmision)
        {
            List<CertificadoEmitidoVista> laLista = new List<CertificadoEmitidoVista>();

            CertificadoEmitidoVista elDeAutenticacion;
            elDeAutenticacion = new Mapeo<RegistroDeCertificado, CertificadoEmitidoVista>().Mapee(laEmision.CertificadoDeAutenticacion);
            laLista.Add(elDeAutenticacion);

            CertificadoEmitidoVista elDeFirma;
            elDeFirma = new Mapeo<RegistroDeCertificado, CertificadoEmitidoVista>().Mapee(laEmision.CertificadoDeFirma);

            laLista.Add(elDeFirma);

            return laLista;
        }
    }
}