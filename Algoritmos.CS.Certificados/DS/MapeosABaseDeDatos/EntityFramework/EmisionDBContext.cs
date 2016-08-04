using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class EmisionDBContext : DbContext
    {
        public DbSet<RegistroDeEmision> Emisiones { get; set; } 
        public DbSet<RegistroDeCertificado> Certificados { get; set; }
        public DbSet<RegistroDeParametro> Parametros { get; set; }

        static EmisionDBContext()
        {
            Database.SetInitializer(new EmisionDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}