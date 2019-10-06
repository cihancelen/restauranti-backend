using System;
using System.Threading.Tasks;
using Restauranti.DataAccess.Repositories.Concrete;
using Restauranti.Dto.Models.Restaurant;
using Restauranti.Service.Helpers;
using Restauranti.Entities.Models;
using System.Collections.Generic;

namespace Restauranti.Service.Services.Restaurant
{
    public class RestaurantService: IRestaurantService
    {
        private readonly RestaurantRepository _restaurantRepository;

        public RestaurantService(RestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task<RestaurantDto> GetRestaurant(RestaurantDto restaurant)
        {
            var entity = AppMapper.Map<Restauranti.Entities.Models.Restaurant>(restaurant);

            var result = await _restaurantRepository.GetRestaurant(entity);

            var dto = AppMapper.Map<RestaurantDto>(result);

            return dto;
        }

        public async Task<List<RestaurantDto>> GetRestaurants()
        {
            var result = await _restaurantRepository.GetRestaurants();

            var dto = AppMapper.Map<List<RestaurantDto>>(result);

            return dto;
        }

        public async Task<RestaurantDto> SaveRestaurant(RestaurantDto restaurantDto)
        {
            var entity = AppMapper.Map<Restauranti.Entities.Models.Restaurant>(restaurantDto);

            await _restaurantRepository.SaveRestaurant(entity);

            return restaurantDto;
        }
    }
}
