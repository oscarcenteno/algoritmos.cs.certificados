using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Certificados.Negocio.UnitTests.GenerarCertificados.ConPolimorfismo;
using NSubstitute;
using System;

namespace Certificados.Negocio.UnitTests.GenerarEmision_Tests.ConInversionDeDependencias_Tests
{
    public class EscenariosDeDatosDeLaEmision: EscenariosDeCertificados
    {
        public DatosDeLaEmisionNacional ObtengaLosDatosDeUnaEmisionNacional()
        {
            DatosDeLaEmisionNacional losDatos;
            losDatos = Substitute.ForPartsOf<DatosDeLaEmisionNacional>();

            losDatos.Nombre = "Miguel";
            losDatos.PrimerApellido = "Suarez";
            losDatos.SegundoApellido = "Godinez";
            losDatos.Identificacion = "3034560333";
            losDatos.AñosDeVigencia.Returns(4);
            losDatos.DireccionDeRevocacion.Returns("http://direccionderevocacion.com");
            losDatos.FechaActual.Returns(new DateTime(2016, 10, 11));

            return losDatos;
        }

        public DatosDeLaEmisionExtranjera ObtengaLosDatosDeUnaEmisionExtranjera()
        {
            DatosDeLaEmisionExtranjera losDatos;
            losDatos = Substitute.ForPartsOf<DatosDeLaEmisionExtranjera>();

            losDatos.Nombre = "Miguel";
            losDatos.PrimerApellido = "Suarez";
            losDatos.SegundoApellido = "Godinez";
            losDatos.Identificacion = "3034560333";
            losDatos.AñosDeVigencia.Returns(4);
            losDatos.DireccionDeRevocacion.Returns("http://direccionderevocacion.com");
            losDatos.FechaActual.Returns(new DateTime(2016, 10, 11));

            return losDatos;
        }
    }
}