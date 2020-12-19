using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Restauranti.BLL.Services.Abstract.Base;
using Restauranti.DAL.Repositories.Abstract;
using Restauranti.Dto.Models;
using Restauranti.Entities;
using Restauranti.Service.Helpers;

namespace Restauranti.BLL.Services.Concrete.Base
{
    public class BaseService<TRepository, TEntity, TDto> : IBaseService<TDto>
        where TEntity : class, IEntity, new()
        where TRepository : IBaseRepository<TEntity>
        where TDto : class, IDto, new()
    {
        private readonly TRepository _repository;

        public BaseService(TRepository repository)
        {
            _repository = repository;
        }

        public virtual async Task<TDto> Create(TDto dto)
        {
            var entity = AppMapper.Map<TEntity>(dto);

            var id = await _repository.Insert(entity);

            dto.Id = id;

            return dto;
        }

        public virtual async Task<List<TDto>> GetAll()
        {
            var result = await _repository.GetAll();

            return AppMapper.Map<List<TDto>>(result);
        }

        public virtual async Task<List<TDto>> GetAll(Expression<Func<TDto, bool>> exp)
        {
            var result = await _repository.GetAll(exp);

            return AppMapper.Map<List<TDto>>(result);
        }

        public virtual async Task<TDto> GetById(long id)
        {
            var result = await _repository.Get(o => o.Id == id);

            return AppMapper.Map<TDto>(result);
        }

        public virtual async Task<TDto> Update(TDto dto)
        {
            var entity = AppMapper.Map<TEntity>(dto);

            var result = await _repository.Update(entity);

            return AppMapper.Map<TDto>(result);
        }

        public virtual async Task<bool> Remove(TDto dto)
        {
            var entity = AppMapper.Map<TEntity>(dto);

            var result = await _repository.Delete(entity);

            return result;
        }
    }
}
