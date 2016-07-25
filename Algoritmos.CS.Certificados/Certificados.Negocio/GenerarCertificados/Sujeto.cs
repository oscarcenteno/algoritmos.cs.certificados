using Sujetos;

namespace Certificados.Negocio.GenerarCertificados
{
    public class Sujeto
    {
        InformacionFormateada laInformacion;

        public Sujeto(DatosDeUnCertificadoDigital losDatos)
        {
            laInformacion = ObtengaLaInformacionFormateada(losDatos);
            laInformacion.Nombre = losDatos.Nombre;
            laInformacion.PrimerApellido = losDatos.PrimerApellido;
            laInformacion.SegundoApellido = losDatos.SegundoApellido;
            laInformacion.Identificacion = losDatos.Identificacion;
        }

        private static InformacionFormateada ObtengaLaInformacionFormateada(DatosDeUnCertificadoDigital losDatos)
        {
            if (ElPropositoEsDeAutenticacion(losDatos))
                return ObtengaLaInformacionDeAutenticacion(losDatos);
            else
                return ObtengaLaInformacionDeFirma(losDatos);
        }

        private static bool ElPropositoEsDeAutenticacion(DatosDeUnCertificadoDigital losDatos)
        {
            return losDatos.ElPropositoEsDeAutenticacion();
        }

        private static InformacionFormateada ObtengaLaInformacionDeAutenticacion(DatosDeUnCertificadoDigital losDatos)
        {
            if (EsNacional(losDatos))
                return new InformacionNacionalDeAutenticacion();
            else
                return new InformacionExtranjeraDeAutenticacion();
        }

        private static bool EsNacional(DatosDeUnCertificadoDigital losDatos)
        {
            return losDatos.EsNacional();
        }

        private static InformacionFormateada ObtengaLaInformacionDeFirma(DatosDeUnCertificadoDigital losDatos)
        {
            if (EsNacional(losDatos))
                return new InformacionNacionalDeFirma();
            else
                return new InformacionExtranjeraDeFirma();
        }

        public string ComoTexto()
        {
            return new SujetoFormateado(laInformacion).ComoTexto();
        }
    }
}