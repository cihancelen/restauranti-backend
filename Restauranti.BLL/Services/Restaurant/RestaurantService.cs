using System.Threading.Tasks;
using Restauranti.DAL.Repositories.Concrete;
using Restauranti.Dto.Models.Restaurant;
using Restauranti.Service.Helpers;
using System.Collections.Generic;
using Restauranti.DAL.Repositories.Abstract;

namespace Restauranti.BLL.Services.Restaurant
{
    public class RestaurantService: IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
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
