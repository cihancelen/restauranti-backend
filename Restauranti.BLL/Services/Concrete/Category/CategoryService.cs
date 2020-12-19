using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.BLL.Services.Abstract.Category;
using Restauranti.BLL.Services.Concrete.Base;
using Restauranti.DAL.Repositories.Abstract.Category;
using Restauranti.Dto.Models.Category;
using Restauranti.Service.Helpers;

namespace Restauranti.BLL.Services.Concrete.Category
{
    public class CategoryService : BaseService<ICategoryRepository, Restauranti.Entities.Models.Category, CategoryDto>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryDto>> GetCategoriesByRestaurant(long restaurantId)
        {
            var result = await _categoryRepository.GetCategoriesByRestaurant(restaurantId);

            var dto = AppMapper.Map<List<CategoryDto>>(result);

            return dto;
        }
    }
}
