using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.BLL.Services.Abstract.Category;
using Restauranti.DAL.Repositories.Abstract.Category;
using Restauranti.Dto.Models.Category;
using Restauranti.Service.Helpers;

namespace Restauranti.BLL.Services.Concrete.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryDto> CreateCategory(CategoryDto category)
        {
            var entity = AppMapper.Map<Entities.Models.Category>(category);

            var result = await _categoryRepository.Insert(entity);

            category.Id = result;

            return category;
        }

        public async Task<List<CategoryDto>> GetCategoriesByRestaurant(long restaurantId)
        {
            var result = await _categoryRepository.GetCategoriesByRestaurant(restaurantId);

            var dto = AppMapper.Map<List<CategoryDto>>(result);

            return dto;
        }

        public async Task<bool> RemoveCategory(CategoryDto category)
        {
            category.IsActive = false;

            await UpdateCategory(category);

            return true;
        }

        public async Task<CategoryDto> UpdateCategory(CategoryDto category)
        {
            var entity = AppMapper.Map<Entities.Models.Category>(category);

            await _categoryRepository.Update(entity);

            return category;
        }
    }
}
