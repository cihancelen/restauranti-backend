using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Restauranti.DAL.Helpers;
using Dapper;
using Restauranti.Entities;

namespace Restauranti.DAL.Repositories.Concrete
{
    public class BaseRepository<T> where T : BaseEntity
    {
        protected IDbConnection Connection => DatabaseHelper.Connection;

        public T Get(long id)
        {
            return Connection.Get<T>(id);
        }

        public List<T> GetAll(object conditions)
        {
            return Connection.GetList<T>(conditions).AsList<T>();
        }

        public async Task<List<T>> GetAllAsync(object conditions)
        {
            return await Task.Run(() => Connection.GetList<T>(conditions).AsList<T>());
        }

        public async Task<T> GetAsync(long id)
        {
            return await Task.Run(() => Connection.Get<T>(id));
        }

        public long Insert(T entity)
        {
            var result = Connection.Insert<T>(entity);

            return (long)result;
        }

        public async Task<long> InsertAsync(T entity)
        {
            var result = await Connection.InsertAsync<T>(entity);

            return (long)result;
        }

    }
}
