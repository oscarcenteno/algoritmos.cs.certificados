using System.Data.Entity;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class RepositorioDeEmision
    { 
        public void Guarde(RegistroDeEmision elRegistroDeLaEmision)
        {
            EmisionDBContext db = new EmisionDBContext();
            DbSet<RegistroDeEmision> laTablaDeEmisiones = db.Emisiones;
            laTablaDeEmisiones.Add(elRegistroDeLaEmision);
            db.SaveChanges();
        }
    }
}