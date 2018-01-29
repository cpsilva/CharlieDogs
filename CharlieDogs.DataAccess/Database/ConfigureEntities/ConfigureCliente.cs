using CharlieDogs.DataAccess.Database.Entites;
using System.Data.Entity;

namespace CharlieDogs.DataAccess.Database
{
    public partial class DatabaseContext : DbContext
    {
        private static void ConfigureCliente(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientesEntity>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<ClientesEntity>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ClientesEntity>()
                .Property(e => e.Cpf)
                .IsUnicode(false);
        }
    }
}