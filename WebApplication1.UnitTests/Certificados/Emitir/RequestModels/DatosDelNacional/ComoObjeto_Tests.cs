using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Certificados.Emitir.RequestModels;
using Certificados.DS.GenerarEmision.ConInversionDeDependencias;

namespace WebApplication1.UnitTests.Certificados.Emitir.RequestModels.DatosDelNacional_Tests
{
    [TestClass]
    public class ComoObjeto_Tests
    {
        private DatosDelNacional losDatos;
        private DatosDeLaEmisionNacionalConDependencias elResultadoEsperado;
        private DatosDeLaEmisionNacionalConDependencias elResultadoObtenido;

        [TestMethod]
        public void ComoObjeto_DatosDeUnSolicitante_ObjetoMapeado()
        {
            elResultadoEsperado = ObtengaLosDatosEsperados();

            InicialiceLosDatosDeUnNacional();
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

        private void InicialiceLosDatosDeUnNacional()
        {
            losDatos = new DatosDelNacional();
            losDatos.Identificacion = "1213412342";
            losDatos.Nombre = "Juan";
            losDatos.PrimerApellido = "Sanchez";
            losDatos.SegundoApellido = "Gomez";
        }

        private DatosDeLaEmisionNacionalConDependencias ObtengaLosDatosEsperados()
        {
            DatosDeLaEmisionNacionalConDependencias losDatos;
            losDatos = new DatosDeLaEmisionNacionalConDependencias();
            losDatos.Identificacion = "1213412342";
            losDatos.Nombre = "Juan";
            losDatos.PrimerApellido = "Sanchez";
            losDatos.SegundoApellido = "Gomez";

            return losDatos;
        }
    }
}