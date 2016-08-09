using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Certificados.Emitir.RequestModels;
using Certificados.DS.GenerarEmision.ConInversionDeDependencias;

namespace WebApplication1.UnitTests.Certificados.Emitir.RequestModels.DatosDelExtranjero_Tests
{
    [TestClass]
    public class ComoObjeto_Tests
    {
        private DatosDelExtranjero losDatos;
        private DatosDeLaEmisionExtranjeraConDependencias elResultadoEsperado;
        private DatosDeLaEmisionExtranjeraConDependencias elResultadoObtenido;

        [TestMethod]
        public void ComoObjeto_DatosDeUnSolicitante_ObjetoMapeado()
        {
            elResultadoEsperado = ObtengaLosDatosEsperados();

            InicialiceLosDatosDeUnExtranjero();
            elResultadoObtenido = losDatos.ComoObjeto();

            SonIguales();
        }

        private void SonIguales()
        {
            Assert.AreEqual(elResultadoEsperado.Nombre, elResultadoObtenido.Nombre);
            Assert.AreEqual(elResultadoEsperado.PrimerApellido, elResultadoObtenido.PrimerApellido);
            Assert.AreEqual(elResultadoEsperado.SegundoApellido, elResultadoObtenido.SegundoApellido);
            Assert.AreEqual(elResultadoEsperado.Identificacion, elResultadoObtenido.Identificacion);
        }

        private void InicialiceLosDatosDeUnExtranjero()
        {
            losDatos = new DatosDelExtranjero();
            losDatos.Identificacion = "1213412342";
            losDatos.Nombre = "Miguel";
            losDatos.PrimerApellido = "Godinez";
            losDatos.SegundoApellido = "Lima";
        }

        private DatosDeLaEmisionExtranjeraConDependencias ObtengaLosDatosEsperados()
        {
            DatosDeLaEmisionExtranjeraConDependencias losDatos;
            losDatos = new DatosDeLaEmisionExtranjeraConDependencias();
            losDatos.Identificacion = "1213412342";
            losDatos.Nombre = "Miguel";
            losDatos.PrimerApellido = "Godinez";
            losDatos.SegundoApellido = "Lima";

            return losDatos;
        }
    }
}