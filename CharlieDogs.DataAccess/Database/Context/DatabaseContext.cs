using CharlieDogs.DataAccess.Database.Entites;
using System.Data.Entity;
using System.Linq;

namespace CharlieDogs.DataAccess.Database
{
    public partial class DatabaseContext : DbContext, IDatabaseContext
    {
        public virtual DbSet<CachorrosEntity> Cachorros { get; set; }
        public virtual DbSet<ClientesEntity> Clientes { get; set; }
        public virtual DbSet<ImagensEntity> Imagens { get; set; }
        public virtual DbSet<RacaEntity> Raca { get; set; }
        public virtual DbSet<VendaCachorroEntity> VendaCachorro { get; set; }   
        public virtual DbSet<VendasEntity> Vendas { get; set; }

        public DatabaseContext()
            : base("name=DatabaseContext")
        {
            // Disable Migrations
            // https://stackoverflow.com/questions/18667172/how-can-i-disable-migration-in-entity-framework-6-0
            System.Data.Entity.Database.SetInitializer<DatabaseContext>(null);

            // Enable Migrations Database.SetInitializer(new
            // MigrateDatabaseToLatestVersion<DatabaseContext,
            // Suframa.Cadsuf.DataAccess.Database.Migrations.Configuration>());

            // Enable Log
            // https://cmatskas.com/logging-and-tracing-with-entity-framework-6/
            //DbInterception.Add(new DatabaseInterceptor());
            Database.Log = NLog.LogManager.GetLogger("db").Trace;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ConfigureCachorros(modelBuilder);
            ConfigureCliente(modelBuilder);
            ConfigureRaca(modelBuilder);
            ConfigureVendaCachorro(modelBuilder);
            ConfigureVendas(modelBuilder);
        }

        public void DetachEntries()
        {
            foreach (var entry in this.ChangeTracker.Entries())
            {
                entry.State = EntityState.Detached;
            }
        }

        /// <summary>
		/// https://stackoverflow.com/questions/16437083/dbcontext-discard-changes-without-disposing
		/// </summary>
		public void DiscartChanges()
        {
            foreach (var entry in this.ChangeTracker.Entries().Where(w => w.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;

                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }
    }
}