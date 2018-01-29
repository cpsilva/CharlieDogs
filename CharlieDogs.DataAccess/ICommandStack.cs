using CharlieDogs.DataAccess.Database.Entites;

namespace CharlieDogs.DataAccess
{
    public interface ICommandStack
    {
        ICommandRepository<CachorrosEntity> Cachorros { get; }
        ICommandRepository<ClientesEntity> Clientes { get; }
        ICommandRepository<RacaEntity> Raca { get; }
        ICommandRepository<VendaCachorroEntity> VendaCachorro { get; }
        ICommandRepository<VendasEntity> Vendas { get; }

        void DetachEntries();

        void Discart();

        void Save();
    }
}