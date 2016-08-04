using System;
using Certificados.Negocio.GenerarCertificados;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Mapeable;
using Certificados.DS.MapeosABaseDeDatos;

namespace Certificados.DS.RegistrarEmision.ConFunciones
{
    class ProcesoDeEmision
    {
        public static void RegistreUnaNuevaEmision(DatosDeLaEmision losDatos)
        {
            RegistroDeEmision elRegistro = GenereElRegistroDeLaEmision(losDatos);

            // Se guarda los registros en base de datos
            new RepositorioDeEmisiones().Guarde(elRegistro);
        }

        private static RegistroDeEmision GenereElRegistroDeLaEmision(DatosDeLaEmision losDatos)
        {
            Emision laEmision = GenereLaEmision(losDatos);

            return MapeeLaEmisionAlRegistro(laEmision);
        }

        private static Emision GenereLaEmision(DatosDeLaEmision losDatos)
        {
            return new Emision(losDatos);
        }

        private static RegistroDeEmision MapeeLaEmisionAlRegistro(Emision laEmision)
        {
            RegistroDeEmision elRegistro = new RegistroDeEmision();
            elRegistro.FechaDeGeneracion = ObtengaLaFecha(laEmision);
            elRegistro.CertificadoDeAutenticacion = ObtengaElRegistroDeCertificadoDeAutenticacion(laEmision);
            elRegistro.CertificadoDeFirma = ObtengaElRegistroDeCertificadoDeFirma(laEmision);

            return elRegistro;
        }

        private static DateTime ObtengaLaFecha(Emision laEmision)
        {
            return laEmision.FechaDeGeneracion;
        }

        private static RegistroDeCertificado ObtengaElRegistroDeCertificadoDeAutenticacion(Emision laEmision)
        {
            CertificadoDigital elCertificadoDeAutenticacion;
            elCertificadoDeAutenticacion = ObtengaElCertificadoDeAutenticacion(laEmision);

            return MapeAUnRegistroDeCertificado(elCertificadoDeAutenticacion);
        }

        private static CertificadoDigital ObtengaElCertificadoDeAutenticacion(Emision laEmision)
        {
            return laEmision.CertificadoDeAutenticacion;
        }

        private static RegistroDeCertificado MapeAUnRegistroDeCertificado(CertificadoDigital elCertificadoDeAutenticacion)
        {
            return new Mapeo<CertificadoDigital, RegistroDeCertificado>().Mapee(elCertificadoDeAutenticacion);
        }

        private static RegistroDeCertificado ObtengaElRegistroDeCertificadoDeFirma(Emision laEmision)
        {
            CertificadoDigital elCertificadoDeFirma;
            elCertificadoDeFirma = ObtengaElCertificadoDeFirma(laEmision);

            return MapeAUnRegistroDeCertificado(elCertificadoDeFirma);
        }

        private static CertificadoDigital ObtengaElCertificadoDeFirma(Emision laEmision)
        {
            return laEmision.CertificadoDeFirma;
        }
    }
}