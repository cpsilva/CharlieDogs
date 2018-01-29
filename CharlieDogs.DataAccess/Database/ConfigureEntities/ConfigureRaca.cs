using CharlieDogs.DataAccess.Database.Entites;
using System.Data.Entity;

namespace CharlieDogs.DataAccess.Database
{
    public partial class DatabaseContext : DbContext
    {
        private static void ConfigureRaca(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RacaEntity>()
               .Property(e => e.Descricao)
               .IsUnicode(false);
        }
    }
}