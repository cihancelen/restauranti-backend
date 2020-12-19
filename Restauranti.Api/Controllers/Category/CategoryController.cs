using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restauranti.BLL.Services.Abstract.Category;
using Restauranti.Dto.Models.Category;

namespace Restauranti.Api.Controllers.Category
{
    public class CategoryController : BaseController<ICategoryService, CategoryDto>
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(
            ICategoryService categoryService
            ): base(categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("GetByRestaurantId/{restaurantId}")]
        public async Task<List<CategoryDto>> GetCategoriesByRestaurant(long restaurantId) => await _categoryService.GetCategoriesByRestaurant(restaurantId);
    }
}
