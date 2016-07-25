using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sujetos;

namespace Algoritmos.CS.Sujetos.UnitTests.ConPolimorfismo_Tests
{
    [TestClass]
    public class GenereUnSujeto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionFormateada laInformacion;

        [TestMethod]
        public void GenereUnSujeto_AutenticacionParaUnaPersonaNacional_PropósitoOUYSerialCorrectos()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO, Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";

            laInformacion = new InformacionNacionalDeAutenticacion();
            laInformacion.Identificacion = "01-0078-5935";
            laInformacion.Nombre = "Marcelino";
            laInformacion.PrimerApellido = "Navarro";
            laInformacion.SegundoApellido = "Quiros";
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_FirmaParaUnaPersonaNacional_PropósitoOUYSerialCorrectos()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (FIRMA), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO, Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";

            laInformacion = new InformacionNacionalDeFirma();
            laInformacion.Identificacion = "01-0078-5935";
            laInformacion.Nombre = "Marcelino";
            laInformacion.PrimerApellido = "Navarro";
            laInformacion.SegundoApellido = "Quiros";
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_AutenticacionParaUnaPersonaExtranjera_PropósitoOUYSerialCorrectos()
        {
            elResultadoEsperado = "CN=JOSE MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";

            laInformacion = new InformacionExtranjeraDeAutenticacion();
            laInformacion.Identificacion = "114145540011";
            laInformacion.Nombre = "Jose Miguel";
            laInformacion.PrimerApellido = "Suarez";
            laInformacion.SegundoApellido = "Godinez";
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_FirmaaraUnaPersonaExtranjera_PropósitoOUYSerialCorrectos()
        {
            elResultadoEsperado = "CN=JOSE MIGUEL SUAREZ GODINEZ (FIRMA), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";

            laInformacion = new InformacionExtranjeraDeFirma();
            laInformacion.Identificacion = "114145540011";
            laInformacion.Nombre = "Jose Miguel";
            laInformacion.PrimerApellido = "Suarez";
            laInformacion.SegundoApellido = "Godinez";
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_AutenticacionParaUnaPersonaExtranjeraConUnSoloApellido_ApellidosBienFormateados()
        {
            elResultadoEsperado = "CN=JOHN SMITH (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN, Surname=SMITH, SERIALNUMBER=NUP-114145540011";

            laInformacion = new InformacionExtranjeraDeAutenticacion();
            laInformacion.Identificacion = "114145540011";
            laInformacion.Nombre = "John";
            laInformacion.PrimerApellido = "Smith";
            laInformacion.SegundoApellido = "";
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_FirmaParaUnaPersonaExtranjeraConUnSoloApellido_ApellidosBienFormateados()
        {
            elResultadoEsperado = "CN=JOHN SMITH (FIRMA), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN, Surname=SMITH, SERIALNUMBER=NUP-114145540011";

            laInformacion = new InformacionExtranjeraDeFirma();
            laInformacion.Identificacion = "114145540011";
            laInformacion.Nombre = "John";
            laInformacion.PrimerApellido = "Smith";
            laInformacion.SegundoApellido = "";
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}