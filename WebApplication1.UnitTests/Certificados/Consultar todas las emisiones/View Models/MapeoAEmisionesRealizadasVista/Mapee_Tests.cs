using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Mapeable.ComparacionesParaPruebasUnitarias;
using WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels;
using Certificados.DS.MapeosABaseDeDatos;
using System;

namespace BS.UnitTests.Certificados.ConsultarLosCertificados.ResponseModels.MapeoAEmisionesRealizadasVista_Tests
{
    [TestClass]
    public class Mapee_Tests
    {
        private List<EmisionRealizadaVista> elResultadoEsperado;
        private List<EmisionRealizadaVista> elResultadoObtenido;
        private List<RegistroDeEmision> lasEmisiones;

        [TestMethod]
        public void Mapee_CasoUnico_ListaMapeada()
        {
            elResultadoEsperado = DosEmisionesRealizadasVista();

            lasEmisiones = DosEmisionesRealizadas();
            elResultadoObtenido = MapeoAEmisionesRealizadasVista.Mapee(lasEmisiones);

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private List<RegistroDeEmision> DosEmisionesRealizadas()
        {
            List<RegistroDeEmision> laLista = new List<RegistroDeEmision>();
            RegistroDeEmision unaEmision = new RegistroDeEmision();
            unaEmision.ID = 1;
            unaEmision.FechaDeGeneracion = new DateTime(2016, 10, 11);
            laLista.Add(unaEmision);

            RegistroDeEmision otraEmision = new RegistroDeEmision();
            otraEmision.ID = 2;
            otraEmision.FechaDeGeneracion = new DateTime(2016, 8, 7);
            laLista.Add(otraEmision);

            return laLista;
        }

        private List<EmisionRealizadaVista> DosEmisionesRealizadasVista()
        {
            List<EmisionRealizadaVista> laLista = new List<EmisionRealizadaVista>();
            EmisionRealizadaVista unaEmision = new EmisionRealizadaVista();
            unaEmision.ID = 1;
            unaEmision.FechaDeGeneracion = new DateTime(2016, 10, 11);
            laLista.Add(unaEmision);

            EmisionRealizadaVista otraEmision = new EmisionRealizadaVista();
            otraEmision.ID = 2;
            otraEmision.FechaDeGeneracion = new DateTime(2016, 8, 7);
            laLista.Add(otraEmision);

            return laLista;
        }
    }
}