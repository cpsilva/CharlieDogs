using CharlieDogs.DataAccess.Database.Entites;
using System.Data.Entity;

namespace CharlieDogs.DataAccess.Database
{
    public partial class DatabaseContext : DbContext
    {
        private static void ConfigureVendaCachorro(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendaCachorroEntity>()
                .HasMany(e => e.Vendas)
                .WithOptional(e => e.VendaCachorro)
                .HasForeignKey(e => e.IdVendaCachorro);
        }
    }
}