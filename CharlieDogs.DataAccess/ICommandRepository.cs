using CharlieDogs.DataAccess.Database;

namespace CharlieDogs.DataAccess
{
    public interface ICommandRepository<T> where T : BaseEntity
    {
        void Apagar(int id);

        void ApagarAssinc(int id);

        void Salvar(T entity);
    }
}