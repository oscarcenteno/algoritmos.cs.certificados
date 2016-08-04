using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;
using WebApplication1.Certificados.Emitir.RequestModels;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace WebApplication1.UnitTests.Certificados.Emitir.RequestModels.DatosDelNacional_Tests
{
    [TestClass]
    public class ComoSolicitante_Tests
    {
        private Solicitante elResultadoEsperado;
        private Solicitante elResultadoObtenido;
        private DatosDelNacional losDatos;

        [TestInitialize]
        public void Inicialice()
        {
            losDatos = new DatosDelNacional();
            losDatos.Identificacion = "0503680922";
            losDatos.Nombre = "Juan";
            losDatos.PrimerApellido = "Sanchez";
            losDatos.SegundoApellido = "Vargas";
        }

        [TestMethod]
        public void ComoSolicitante_CasoUnico_Mapeado()
        {
            elResultadoEsperado = CreeUnSolicitanteExtranjero();

            elResultadoObtenido = losDatos.ComoSolicitante();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private Solicitante CreeUnSolicitanteExtranjero()
        {
            SolicitanteNacional elSolicitante = new SolicitanteNacional();
            elSolicitante.Identificacion= "0503680922";
            elSolicitante.Nombre = "Juan";
            elSolicitante.PrimerApellido= "Sanchez";
            elSolicitante.SegundoApellido= "Vargas";

            return elSolicitante;
        }
    }
}
