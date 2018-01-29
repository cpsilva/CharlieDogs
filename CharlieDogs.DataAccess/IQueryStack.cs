using CharlieDogs.DataAccess.Database.Entites;

namespace CharlieDogs.DataAccess
{
    public interface IQueryStack
    {
        IQueryRepository<CachorrosEntity> Cachorros { get; }
        IQueryRepository<ClientesEntity> Clientes { get; }
        IQueryRepository<RacaEntity> Raca { get; }
        IQueryRepository<VendaCachorroEntity> VendaCachorro { get; }
        IQueryRepository<VendasEntity> Vendas { get; }
    }
}