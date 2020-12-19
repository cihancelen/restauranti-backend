using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Restauranti.Entities;

namespace Restauranti.DAL.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter);

        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null);

        Task<List<T>> GetAll(object filter);

        Task<List<T>> GetAllActive();

        Task<long> Insert(T entity);

        Task<bool> Update(T entity);

        Task<bool> Delete(T entity);
    }
}
