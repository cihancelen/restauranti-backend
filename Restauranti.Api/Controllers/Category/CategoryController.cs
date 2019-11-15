using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restauranti.BLL.Services.Abstract.Category;
using Restauranti.Dto.Models.Category;

namespace Restauranti.Api.Controllers.Category
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(
            ICategoryService categoryService
            )
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<CategoryDto> CreateCategory(CategoryDto category) => await _categoryService.CreateCategory(category);

        [HttpPost]
        [Route("GetByRestaurantId")]
        public async Task<List<CategoryDto>> GetCategoriesByRestaurant(long restaurantId) => await _categoryService.GetCategoriesByRestaurant(restaurantId);

        [HttpPost]
        [Route("Update")]
        public async Task<CategoryDto> UpdateCategory(CategoryDto category) => await _categoryService.UpdateCategory(category);

        [HttpPost]
        [Route("Remove")]
        public async Task<bool> RemoveCategory(CategoryDto category) => await _categoryService.RemoveCategory(category);

    }
}
