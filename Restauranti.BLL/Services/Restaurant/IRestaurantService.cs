using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.Dto.Models.Restaurant;

namespace Restauranti.BLL.Services.Restaurant
{
    public interface IRestaurantService
    {
        Task<RestaurantDto> GetRestaurant(RestaurantDto restaurant);
        Task<List<RestaurantDto>> GetRestaurants();
        Task<RestaurantDto> SaveRestaurant(RestaurantDto restaurantDto);
    }
}
