using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Mapeable.ComparacionesParaPruebasUnitarias;

using WebApplication1.Certificados.ConsultarLosCertificados.ViewModels;
using BS.Certificados.ConsultarLosCertificados.ResponseModels;

namespace BS.UnitTests.Certificados.ConsultarLosCertificados.ResponseModels.MapeoACertificadosEmitidosVista_Tests
{
    [TestClass]
    public class Mapee_Tests
    {
        private List<CertificadoEmitidoVista> elResultadoEsperado;
        private List<CertificadoEmitidoVista> elResultadoObtenido;
        private List<CertificadoEmitido> losCertificados;

        [TestMethod]
        public void Mapee_CasoUnico_ListaMapeada()
        {
            elResultadoEsperado = DosCertificadosEmitidosVista();

            losCertificados = DosCertificadosEmitidos();
            elResultadoObtenido = MapeoACertificadosEmitidosVista.Mapee(losCertificados);

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private List<CertificadoEmitido> DosCertificadosEmitidos()
        {
            List<CertificadoEmitido> laLista = new List<CertificadoEmitido>();
            CertificadoEmitido unRegistro = new CertificadoEmitido();
            unRegistro.ID = 1;
            unRegistro.Crl = "El Crl";
            unRegistro.FechaDeEmision = new System.DateTime(2014, 12, 31);
            unRegistro.FechaDeVencimiento = new System.DateTime(2018, 12, 31);
            unRegistro.Sujeto = "El Sujeto";
            laLista.Add(unRegistro);

            CertificadoEmitido otroRegistro = new CertificadoEmitido();
            otroRegistro.ID = 2;
            otroRegistro.Crl = "Otro Crl";
            otroRegistro.FechaDeEmision = new System.DateTime(2015, 11, 30);
            otroRegistro.FechaDeVencimiento = new System.DateTime(2019, 11, 30);
            otroRegistro.Sujeto = "Otro Sujeto";
            laLista.Add(otroRegistro);

            return laLista;
        }

        private List<CertificadoEmitidoVista> DosCertificadosEmitidosVista()
        {
            List<CertificadoEmitidoVista> laLista = new List<CertificadoEmitidoVista>();
            CertificadoEmitidoVista unCertificado = new CertificadoEmitidoVista();
            unCertificado.Crl = "El Crl";
            unCertificado.FechaDeEmision = new System.DateTime(2014, 12, 31);
            unCertificado.FechaDeVencimiento = new System.DateTime(2018, 12, 31);
            unCertificado.Sujeto = "El Sujeto";
            laLista.Add(unCertificado);

            CertificadoEmitidoVista otroCertificado = new CertificadoEmitidoVista();
            otroCertificado.Crl = "Otro Crl";
            otroCertificado.FechaDeEmision = new System.DateTime(2015, 11, 30);
            otroCertificado.FechaDeVencimiento = new System.DateTime(2019, 11, 30);
            otroCertificado.Sujeto = "Otro Sujeto";
            laLista.Add(otroCertificado);

            return laLista;
        }
    }
}