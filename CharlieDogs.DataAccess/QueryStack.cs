using CharlieDogs.DataAccess.Database;
using CharlieDogs.DataAccess.Database.Entites;

namespace CharlieDogs.DataAccess
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
    /// </summary>
    public class QueryStack : IQueryStack
    {
        private readonly IDatabaseContext context;
        public IQueryRepository<CachorrosEntity> Cachorros { get; }

        public IQueryRepository<ClientesEntity> Clientes { get; }

        public IQueryRepository<RacaEntity> Raca { get; }

        public IQueryRepository<VendaCachorroEntity> VendaCachorro { get; }

        public IQueryRepository<VendasEntity> Vendas { get; }

        public QueryStack(IDatabaseContext databaseContext)
        {
            context = databaseContext;

            Cachorros = new QueryRepository<CachorrosEntity>(context);
            Clientes = new QueryRepository<ClientesEntity>(context);
            Raca = new QueryRepository<RacaEntity>(context);
            VendaCachorro = new QueryRepository<VendaCachorroEntity>(context);
            Vendas = new QueryRepository<VendasEntity>(context);
        }
    }
}