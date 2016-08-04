using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Mapeable.ComparacionesParaPruebasUnitarias;
using WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels;
using BS.Certificados.ConsultarTodasLasEmisiones.ResponseModels;

namespace BS.UnitTests.Certificados.ConsultarLosCertificados.ResponseModels.MapeoAEmisionesRealizadasVista_Tests
{
    [TestClass]
    public class Mapee_Tests
    {
        private List<EmisionRealizadaVista> elResultadoEsperado;
        private List<EmisionRealizadaVista> elResultadoObtenido;
        private List<EmisionRealizada> lasEmisiones;

        [TestMethod]
        public void Mapee_CasoUnico_ListaMapeada()
        {
            elResultadoEsperado = DosEmisionesRealizadasVista();

            lasEmisiones = DosEmisionesRealizadas();
            elResultadoObtenido = MapeoAEmisionesRealizadasVista.Mapee(lasEmisiones);

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private List<EmisionRealizada> DosEmisionesRealizadas()
        {
            List<EmisionRealizada> laLista = new List<EmisionRealizada>();
            EmisionRealizada unaEmision = new EmisionRealizada();
            unaEmision.ID = 1;
            unaEmision.Identificacion = "11111111";
            laLista.Add(unaEmision);

            EmisionRealizada otraEmision = new EmisionRealizada();
            otraEmision.ID = 2;
            otraEmision.Identificacion = "22222222";
            laLista.Add(otraEmision);

            return laLista;
        }

        private List<EmisionRealizadaVista> DosEmisionesRealizadasVista()
        {
            List<EmisionRealizadaVista> laLista = new List<EmisionRealizadaVista>();
            EmisionRealizadaVista unaEmision = new EmisionRealizadaVista();
            unaEmision.ID = 1;
            unaEmision.Identificacion = "11111111";
            laLista.Add(unaEmision);

            EmisionRealizadaVista otraEmision = new EmisionRealizadaVista();
            otraEmision.ID = 2;
            otraEmision.Identificacion = "22222222";
            laLista.Add(otraEmision);

            return laLista;
        }
    }
}