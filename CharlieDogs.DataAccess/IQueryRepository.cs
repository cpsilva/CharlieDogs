using CharlieDogs.DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CharlieDogs.DataAccess
{
    public interface IQueryRepository<T> where T : BaseEntity
    {
        int Contar(Expression<Func<T, bool>> predicate);

        Task<int> ContarAssinc(Expression<Func<T, bool>> predicate);

        bool Existe(Expression<Func<T, bool>> predicate);

        List<T> Listar();

        List<U> Listar<U>();

        List<T> Listar(Expression<Func<T, bool>> predicate);

        List<U> Listar<U>(Expression<Func<T, bool>> predicate);

        List<T> Listar(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");

        Task<List<T>> ListarAssinc();

        Task<List<T>> ListarAssinc(Expression<Func<T, bool>> predicate);

        T Selecionar(Expression<Func<T, bool>> predicate);

        U Selecionar<U>(Expression<Func<T, bool>> predicate);

        Task<T> SelecionarAssinc(Expression<Func<T, bool>> predicate);

        Task<U> SelecionarAssinc<U>(Expression<Func<T, bool>> predicate);

        T SelecionarUltimo<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order);
    }
}