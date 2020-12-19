using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.BLL.Services.Abstract.Base;
using Restauranti.DAL.Repositories.Concrete.Category;
using Restauranti.Dto.Models.Category;

namespace Restauranti.BLL.Services.Abstract.Category
{
    public interface ICategoryService : IBaseService<CategoryDto>
    {
        Task<List<CategoryDto>> GetCategoriesByRestaurant(long restaurantId);
    }
}
