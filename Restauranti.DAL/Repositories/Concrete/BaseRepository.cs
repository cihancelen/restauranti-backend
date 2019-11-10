using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Restauranti.DAL.Helpers;
using Dapper;
using Restauranti.Entities;
using Restauranti.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Restauranti.DAL.Repositories.Concrete
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected IDbConnection Connection => DatabaseHelper.Connection;

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            var result = await Connection.GetAsync<TEntity>(filter);

            return result;
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            var result = (await Connection.GetListAsync<TEntity>(filter));

            return result.AsList();
        }

        public async Task<List<TEntity>> GetAll(object filter)
        {
            var result = await Connection.GetListAsync<TEntity>();

            return result.AsList();
        }

        public async Task<List<TEntity>> GetAllActive(Expression<Func<TEntity, bool>> filter = null)
        {
            var result = (await Connection.GetListAsync<TEntity>()).AsList();

            var filtered = result.FindAll(x => x.IsActive);

            return filtered;
        }

        public async Task<long> Insert(TEntity entity)
        {
            var result = await Connection.InsertAsync<TEntity>(entity);

            return (long)result;
        }

        public async Task<bool> Update(TEntity entity)
        {
            var result = await Connection.UpdateAsync<TEntity>(entity);

            return result > 0;
        }

        public async Task<bool> Delete(TEntity entity)
        {
            entity.IsActive = false;

            var result = await Connection.UpdateAsync<TEntity>(entity);

            return result > 0;
        }
    }


    //public class BaseRepository<T> where T : BaseEntity
    //{
    //    protected IDbConnection Connection => DatabaseHelper.Connection;

    //    public T Get(long id)
    //    {
    //        return Connection.Get<T>(id);
    //    }

    //    public List<T> GetAll(object conditions)
    //    {
    //        return Connection.GetList<T>(conditions).AsList<T>();
    //    }

    //    public async Task<List<T>> GetAllAsync(object conditions)
    //    {
    //        return await Task.Run(() => Connection.GetList<T>(conditions).AsList<T>());
    //    }

    //    public async Task<T> GetAsync(long id)
    //    {
    //        return await Task.Run(() => Connection.Get<T>(id));
    //    }

    //    public long Insert(T entity)
    //    {
    //        var result = Connection.Insert<T>(entity);

    //        return (long)result;
    //    }

    //    private async Task<long> InsertAsync(T entity)
    //    {
    //        var result = await Connection.InsertAsync<T>(entity);

    //        return (long)result;
    //    }

    //    private async Task<long> Update(T entity)
    //    {
    //        var result = await Connection.UpdateAsync<T>(entity);

    //        return (long)result;
    //    }

    //    public async Task<long> Save(T entity)
    //    {
    //        long result;

    //        if (entity.Id != 0)
    //        {
    //            result = await Update(entity);
    //        }
    //        else
    //        {
    //            result = await InsertAsync(entity);
    //        }

    //        return result;
    //    }

    //}
}
