using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Restauranti.BLL.Services.Abstract.Base
{
    public interface IBaseService<TDto>
    {
        Task<TDto> Create(TDto dto);

        Task<TDto> GetById(long id);

        Task<List<TDto>> GetAll();

        Task<List<TDto>> GetAll(Expression<Func<TDto, bool>> exp);

        Task<TDto> Update(TDto dto);

        Task<bool> Remove(TDto dto);
    }
}
