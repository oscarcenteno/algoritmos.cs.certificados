using Sujetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificados.Negocio.GenerarCertificados.ConObjetos
{
    public class Sujeto
    {
        InformacionFormateada laInformacion;

        public Sujeto(string elNombre, string elPrimerApellido, string elSegundoApellido, string laIdentificacion, TipoDeIdentificacion elTipoDeIdentificacion, TipoDeCertificado elTipoDeCertificado)
        {
            laInformacion = ObtengaLaInformacionFormateada(elTipoDeIdentificacion, elTipoDeCertificado);
            laInformacion.Nombre = elNombre;
            laInformacion.PrimerApellido = elPrimerApellido;
            laInformacion.SegundoApellido = elSegundoApellido;
            laInformacion.Identificacion = laIdentificacion;
        }

        private static InformacionFormateada ObtengaLaInformacionFormateada(TipoDeIdentificacion elTipoDeIdentificacion, TipoDeCertificado elTipoDeCertificado)
        {
            if (ElPropositoEsDeAutenticacion(elTipoDeCertificado))
                return ObtengaLaInformacionDeAutenticacion(elTipoDeIdentificacion);
            else
                return ObtengaLaInformacionDeFirma(elTipoDeIdentificacion);
        }

        private static bool ElPropositoEsDeAutenticacion(TipoDeCertificado elTipoDeCertificado)
        {
            return elTipoDeCertificado == TipoDeCertificado.Autenticacion;
        }

        private static InformacionFormateada ObtengaLaInformacionDeFirma(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return new InformacionNacionalDeFirma();
            else
                return new InformacionExtranjeraDeFirma();
        }

        private static bool EsNacional(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            return elTipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        private static InformacionFormateada ObtengaLaInformacionDeAutenticacion(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
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