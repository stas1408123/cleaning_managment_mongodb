using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CleaningManagement.BLL.Services.Interface
{
    public interface IGenericService<TModel>
    {
        Task<TModel> Add(TModel model);

        Task<TModel> GetById(Guid id);

        Task<IReadOnlyList<TModel>> GetAll();

        Task<IEnumerable<TModel>> Get(Expression<Func<TModel, bool>> predicate);

        Task<TModel> Update(TModel model);

        Task Delete(Guid id);
    }
}
