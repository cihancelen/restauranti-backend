using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Restauranti.DAL.Repositories.Abstract
{
    public interface IBaseRepository<T>
    {
        T Get(T entity);

        Task<T> GetAsync(T entity);

        List<T> GetAll(object conditions);

        Task<List<T>> GetAllAsync(object conditions);

        long Insert(T entity);

        Task<long> InsertAsync(T entity);
    }
}
