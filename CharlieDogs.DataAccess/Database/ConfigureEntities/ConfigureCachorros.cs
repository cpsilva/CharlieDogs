using CharlieDogs.DataAccess.Database.Entites;
using System.Data.Entity;

namespace CharlieDogs.DataAccess.Database
{
    public partial class DatabaseContext : DbContext
    {
        private static void ConfigureCachorros(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CachorrosEntity>()
                .Property(e => e.Descricao)
                .IsUnicode(false);
        }
    }
}