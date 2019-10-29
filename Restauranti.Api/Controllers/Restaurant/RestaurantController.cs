using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restauranti.Dto.Models.Restaurant;
using Restauranti.BLL.Services.Restaurant;
using Microsoft.AspNetCore.Authorization;

namespace Restauranti.Api.Controllers.Restaurant
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : BaseController
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(
            IRestaurantService restaurantService
            )
        {
            _restaurantService = restaurantService;
        }

        [HttpPost]
        [Route("GetRestaurant")]
        public async Task<RestaurantDto> GetRestaurant(RestaurantDto dto) => await _restaurantService.GetRestaurant(dto);

        [HttpPost]
        [Route("GetRestaurants")]
        [Authorize]
        public async Task<List<RestaurantDto>> GetRestaurants() => await _restaurantService.GetRestaurants();

        [HttpPost]
        [Route("SaveRestaurant")]
        public async Task<RestaurantDto> SaveRestaurant(RestaurantDto dto) => await _restaurantService.SaveRestaurant(dto);

    }
}
