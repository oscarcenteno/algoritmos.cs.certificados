using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Mapeable.ComparacionesParaPruebasUnitarias;
using WebApplication1.Certificados.ConsultarLosCertificados.ViewModels;
using Certificados.DS.MapeosABaseDeDatos;

namespace BS.UnitTests.Certificados.ConsultarLosCertificados.ResponseModels.MapeoACertificadosEmitidosVista_Tests
{
    [TestClass]
    public class Mapee_Tests
    {
        private List<CertificadoVista> elResultadoEsperado;
        private List<CertificadoVista> elResultadoObtenido;
        private RegistroDeEmision laEmision;

        [TestMethod]
        public void Mapee_CasoUnico_ListaMapeada()
        {
            elResultadoEsperado = ObtengaLosDosCertificadosEsperados();

            laEmision = ObtengaLaEmision();
            elResultadoObtenido = new MapeoACertificadosVista(laEmision).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private RegistroDeEmision ObtengaLaEmision()
        {
            RegistroDeEmision elRegistroDeEmision = new RegistroDeEmision();

            RegistroDeCertificado unRegistro = new RegistroDeCertificado();
            unRegistro.ID = 1;
            unRegistro.DireccionDeRevocacion = "http://crl";
            unRegistro.FechaDeEmision = new System.DateTime(2014, 12, 31);
            unRegistro.FechaDeVencimiento = new System.DateTime(2018, 12, 31);
            unRegistro.Sujeto = "El Sujeto de Autenticacion";
            elRegistroDeEmision.CertificadoDeAutenticacion = unRegistro;

            RegistroDeCertificado otroRegistro = new RegistroDeCertificado();
            otroRegistro.ID = 2;
            otroRegistro.DireccionDeRevocacion = "http://crl2";
            otroRegistro.FechaDeEmision = new System.DateTime(2015, 11, 30);
            otroRegistro.FechaDeVencimiento = new System.DateTime(2019, 11, 30);
            otroRegistro.Sujeto = "El Sujeto de Firma";
            elRegistroDeEmision.CertificadoDeFirma = otroRegistro;

            return elRegistroDeEmision;
        }

        private List<CertificadoVista> ObtengaLosDosCertificadosEsperados()
        {
            List<CertificadoVista> laLista = new List<CertificadoVista>();
            CertificadoVista unCertificado = new CertificadoVista();
            unCertificado.DireccionDeRevocacion = "http://crl";
            unCertificado.FechaDeEmision = new System.DateTime(2014, 12, 31);
            unCertificado.FechaDeVencimiento = new System.DateTime(2018, 12, 31);
            unCertificado.Sujeto = "El Sujeto de Autenticacion";
            laLista.Add(unCertificado);

            CertificadoVista otroCertificado = new CertificadoVista();
            otroCertificado.DireccionDeRevocacion = "http://crl2";
            otroCertificado.FechaDeEmision = new System.DateTime(2015, 11, 30);
            otroCertificado.FechaDeVencimiento = new System.DateTime(2019, 11, 30);
            otroCertificado.Sujeto = "El Sujeto de Firma";
            laLista.Add(otroCertificado);

            return laLista;
        }
    }
}