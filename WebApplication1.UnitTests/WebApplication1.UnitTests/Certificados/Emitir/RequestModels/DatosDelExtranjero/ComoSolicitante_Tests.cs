using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;
using WebApplication1.Certificados.Emitir.RequestModels;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace WebApplication1.UnitTests.Certificados.Emitir.RequestModels.DatosDelExtranjero_Tests
{
    [TestClass]
    public class ComoSolicitante_Tests
    {
        private Solicitante elResultadoEsperado;
        private Solicitante elResultadoObtenido;
        private DatosDelExtranjero losDatos;

        [TestInitialize]
        public void Inicialice()
        {
            losDatos = new DatosDelExtranjero();
            losDatos.Identificacion = "1213412342";
            losDatos.Nombre = "John";
            losDatos.PrimerApellido = "Smith";
            losDatos.SegundoApellido = "Jones";
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
            SolicitanteExtranjero elSolicitante = new SolicitanteExtranjero();
            elSolicitante.Identificacion= "1213412342";
            elSolicitante.Nombre = "John";
            elSolicitante.PrimerApellido= "Smith";
            elSolicitante.SegundoApellido= "Jones";

            return elSolicitante;
        }
    }
}
