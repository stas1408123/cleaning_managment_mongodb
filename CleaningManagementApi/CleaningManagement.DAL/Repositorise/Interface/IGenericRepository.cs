using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CleaningManagement.DAL.Repositorise.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> GetById(Guid id);

        Task<IReadOnlyList<TEntity>> GetAll();

        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> Update(TEntity entity);

        Task Delete(Guid id);
    }
}
