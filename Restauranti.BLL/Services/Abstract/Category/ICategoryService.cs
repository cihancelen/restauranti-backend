using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.Dto.Models.Category;

namespace Restauranti.BLL.Services.Abstract.Category
{
    public interface ICategoryService
    {
        Task<CategoryDto> CreateCategory(CategoryDto category);

        Task<CategoryDto> UpdateCategory(CategoryDto category);

        Task<List<CategoryDto>> GetCategoriesByRestaurant(long restaurantId);

        Task<bool> RemoveCategory(CategoryDto category);
    }
}
