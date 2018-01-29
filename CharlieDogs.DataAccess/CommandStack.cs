using CharlieDogs.DataAccess.Database;
using CharlieDogs.DataAccess.Database.Entites;

namespace CharlieDogs.DataAccess
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
    /// </summary>
    public class CommandStack : ICommandStack
    {
        private readonly IDatabaseContext context;
        public ICommandRepository<CachorrosEntity> Cachorros { get; }
        public ICommandRepository<ClientesEntity> Clientes { get; }
        public ICommandRepository<RacaEntity> Raca { get; }
        public ICommandRepository<VendaCachorroEntity> VendaCachorro { get; }
        public ICommandRepository<VendasEntity> Vendas { get; }

        public CommandStack(IDatabaseContext databaseContext)
        {
            context = databaseContext;

            Cachorros = new CommandRepository<CachorrosEntity>(context);
            Clientes = new CommandRepository<ClientesEntity>(context);
            Raca = new CommandRepository<RacaEntity>(context);
            VendaCachorro = new CommandRepository<VendaCachorroEntity>(context);
            Vendas = new CommandRepository<VendasEntity>(context);
        }

        public void DetachEntries()
        {
            context.DetachEntries();
        }

        public void Discart()
        {
            context.DiscartChanges();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}