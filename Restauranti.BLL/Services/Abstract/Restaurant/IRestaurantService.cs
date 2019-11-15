using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.Dto.Models.Restaurant;

namespace Restauranti.BLL.Services.Abstract.Restaurant
{
    public interface IRestaurantService
    {
        Task<RestaurantDto> GetRestaurantById(long restaurantId);

        Task<RestaurantDto> CreateRestaurant(RestaurantDto restaurant);

        Task<RestaurantDto> UpdateRestaurant(RestaurantDto restaurant);

        Task<bool> RemoveRestaurant(RestaurantDto restaurant);
    }
}
