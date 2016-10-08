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
            EmisionDBContext elContexto = new EmisionDBContext();
            DbSet<RegistroDeEmision> laTablaDeEmisiones = elContexto.Emisiones;

            return laTablaDeEmisiones.ToList();
        }

        public static RegistroDeEmision ObtengaPorId(int id)
        {
            EmisionDBContext elContexto = new EmisionDBContext();
            DbSet<RegistroDeEmision> laTablaDeEmisiones = elContexto.Emisiones;
            var laConsultaConAutenticacion = laTablaDeEmisiones.Include("CertificadoDeAutenticacion");
            var laConsultaConFirma = laConsultaConAutenticacion.Include("CertificadoDeFirma");
            var lasEmisionesQueCumplen = laConsultaConFirma.Where(c => c.ID == id);

            return lasEmisionesQueCumplen.FirstOrDefault();
        }
    }
}