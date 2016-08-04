using Certificados.DS.MapeosABaseDeDatos;
using System.Collections.Generic;
using System.Linq;

namespace Certificados.DS.Consultas
{
    public static class RepositorioDeEmisiones
    {
        public static List<RegistroDeEmision> ConsulteTodas()
        {
            return new EmisionDBContext().Emisiones.ToList();
        }

        public static RegistroDeEmision ObtengaPorId(int id)
        {
            return new EmisionDBContext().Emisiones.Include("CertificadoDeAutenticacion").Include("CertificadoDeFirma").Where(c => c.ID == id).FirstOrDefault();
        }
    }
}