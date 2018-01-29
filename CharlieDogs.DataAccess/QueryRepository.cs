using CharlieDogs.DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CharlieDogs.DataAccess
{
    public class QueryRepository<T> : IQueryRepository<T> where T : BaseEntity
    {
        private readonly IDatabaseContext _dbContext;

        internal QueryRepository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Contar(Expression<Func<T, bool>> predicate)
        {
            return _dbContext
                .Set<T>()
                .Where(predicate)
                .AsNoTracking()
                .Count();
        }

        public async Task<int> ContarAssinc(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext
                .Set<T>()
                .Where(predicate)
                .AsNoTracking()
                .CountAsync();
        }

        public bool Existe(Expression<Func<T, bool>> predicate)
        {
            return _dbContext
                .Set<T>()
                .AsNoTracking()
                .Any(predicate);
        }

        public T Find(object id)
        {
            return _dbContext
                .Set<T>()
                .Find(id);
        }

        public List<T> Listar()
        {
            return _dbContext
                .Set<T>()
                .AsNoTracking()
                .ToList();
        }

        public List<U> Listar<U>()
        {
            var entities = this.Listar();
            return AutoMapper.Mapper.Map<List<U>>(entities);
        }

        public List<T> Listar(Expression<Func<T, bool>> predicate)
        {
            return _dbContext
                .Set<T>()
                .Where(predicate)
                .AsNoTracking()
                .ToList();
        }

        public List<U> Listar<U>(Expression<Func<T, bool>> predicate)
        {
            return AutoMapper.Mapper.Map<List<U>>(this.Listar(predicate));
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public List<T> Listar(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = _dbContext.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query)
                    .AsNoTracking()
                    .ToList();
            }
            else
            {
                return query
                    .AsNoTracking()
                    .ToList();
            }
        }

        public async Task<List<T>> ListarAssinc()
        {
            return await _dbContext
                .Set<T>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<T>> ListarAssinc(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext
                .Set<T>()
                .Where(predicate)
                .AsNoTracking()
                .ToListAsync();
        }

        public T Selecionar(Expression<Func<T, bool>> predicate)
        {
            return _dbContext
                .Set<T>()
                .AsNoTracking()
                .SingleOrDefault(predicate);
        }

        public U Selecionar<U>(Expression<Func<T, bool>> predicate)
        {
            var entity = _dbContext
                .Set<T>()
                .AsNoTracking()
                .SingleOrDefault(predicate);

            return AutoMapper.Mapper.Map<U>(entity);
        }

        public async Task<T> SelecionarAssinc(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext
                .Set<T>()
                .AsNoTracking()
                .SingleOrDefaultAsync(predicate);
        }

        public async Task<U> SelecionarAssinc<U>(Expression<Func<T, bool>> predicate)
        {
            var entity = await _dbContext
                .Set<T>()
                .AsNoTracking()
                .SingleOrDefaultAsync(predicate);

            return AutoMapper.Mapper.Map<U>(entity);
        }

        public T SelecionarUltimo<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order)
        {
            return _dbContext
                .Set<T>()
                .AsNoTracking()
                .OrderByDescending(order)
                .FirstOrDefault(predicate);
        }
    }
}