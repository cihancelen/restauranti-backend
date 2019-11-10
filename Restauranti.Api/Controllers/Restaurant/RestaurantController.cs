using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restauranti.Dto.Models.Restaurant;
using Microsoft.AspNetCore.Authorization;
using Restauranti.BLL.Services.Abstract.Restaurant;

namespace Restauranti.Api.Controllers.Restaurant
{
    [Authorize]
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
        [Route("GetRestaurantById")]
        public async Task<RestaurantDto> GetRestaurant(RestaurantDto dto) => await _restaurantService.GetRestaurantById(dto.Id);

        [HttpPost]
        [Route("SaveRestaurant")]
        public async Task<RestaurantDto> SaveRestaurant(RestaurantDto dto) => await _restaurantService.CreateRestaurant(dto);

        [HttpPost]
        [Route("UpdateRestaurant")]
        public async Task<RestaurantDto> UpdateRestaurant(RestaurantDto dto) => await _restaurantService.UpdateRestaurant(dto);

        [HttpPost]
        [Route("RemoveRestaurant")]
        public async Task<bool> RemoveRestaurant(RestaurantDto dto) => await _restaurantService.RemoveRestaurant(dto);

    }
}
