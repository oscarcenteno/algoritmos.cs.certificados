using Sujetos;

namespace Certificados.Negocio.GenerarCertificados.ConTellDontAsk
{
    public class Sujeto
    {
        InformacionFormateada laInformacion;

        public Sujeto(DatosParaUnCertificadoDigital losDatos)
        {
            laInformacion = losDatos.InformacionFormateada;
            laInformacion.Nombre = losDatos.Nombre;
            laInformacion.PrimerApellido = losDatos.PrimerApellido;
            laInformacion.SegundoApellido = losDatos.SegundoApellido;
            laInformacion.Identificacion = losDatos.Identificacion;
        }

        public string ComoTexto()
        {
            return new SujetoFormateado(laInformacion).ComoTexto();
        }
    }
}