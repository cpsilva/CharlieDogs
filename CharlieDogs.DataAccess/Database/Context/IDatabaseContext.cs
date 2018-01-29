using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CharlieDogs.DataAccess.Database
{
    public interface IDatabaseContext
    {
        System.Data.Entity.Database Database { get; }

        void DetachEntries();

        void DiscartChanges();

        DbEntityEntry Entry(object entity);

        int SaveChanges();

        DbSet<T> Set<T>() where T : class;
    }
}