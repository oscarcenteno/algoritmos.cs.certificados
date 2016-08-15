using Sujetos;

namespace Certificados.Negocio.GenerarCertificados.ConParameterObject
{
    public class Sujeto
    {
        InformacionFormateada laInformacion;

        public Sujeto(DatosParaUnCertificadoDigital losDatos)
        {
            laInformacion = ObtengaLaInformacionFormateada(losDatos);
            laInformacion.Nombre = losDatos.Nombre;
            laInformacion.PrimerApellido = losDatos.PrimerApellido;
            laInformacion.SegundoApellido = losDatos.SegundoApellido;
            laInformacion.Identificacion = losDatos.Identificacion;
        }

        private static InformacionFormateada ObtengaLaInformacionFormateada(DatosParaUnCertificadoDigital losDatos)
        {
            if (ElPropositoEsDeAutenticacion(losDatos))
                return ObtengaLaInformacionDeAutenticacion(losDatos);
            else
                return ObtengaLaInformacionDeFirma(losDatos);
        }

        private static bool ElPropositoEsDeAutenticacion(DatosParaUnCertificadoDigital losDatos)
        {
            // TODO: Mas de una operacion
            return losDatos.TipoDeCertificado == TipoDeCertificado.Autenticacion;
        }

        private static InformacionFormateada ObtengaLaInformacionDeFirma(DatosParaUnCertificadoDigital losDatos)
        {
            if (EsNacional(losDatos))
                return new InformacionNacionalDeFirma();
            else
                return new InformacionExtranjeraDeFirma();
        }

        private static bool EsNacional(DatosParaUnCertificadoDigital losDatos)
        {
            // TODO: Mas de una operacion
            return losDatos.TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        private static InformacionFormateada ObtengaLaInformacionDeAutenticacion(DatosParaUnCertificadoDigital losDatos)
        {
            if (EsNacional(losDatos))
                return new InformacionNacionalDeAutenticacion();
            else
                return new InformacionExtranjeraDeAutenticacion();
        }

        public string ComoTexto()
        {
            return new SujetoFormateado(laInformacion).ComoTexto();
        }
    }
}