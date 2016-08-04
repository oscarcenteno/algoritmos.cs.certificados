using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class RepositorioDeEmisiones
    { 
        public void Guarde(RegistroDeEmision elRegistroDeLaEmision)
        {
            EmisionDBContext elContexto = new EmisionDBContext();
            DbSet<RegistroDeEmision> laTablaDeEmisiones = elContexto.Emisiones;
            laTablaDeEmisiones.Add(elRegistroDeLaEmision);
            elContexto.SaveChanges();
        }

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