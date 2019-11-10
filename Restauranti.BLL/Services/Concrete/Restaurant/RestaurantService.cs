using System.Threading.Tasks;
using Restauranti.Dto.Models.Restaurant;
using Restauranti.Service.Helpers;
using System.Collections.Generic;
using Restauranti.DAL.Repositories.Abstract.Restaurant;
using Restauranti.BLL.Services.Abstract.Restaurant;

namespace Restauranti.BLL.Services.Concrete.Restaurant
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task<RestaurantDto> GetRestaurantById(long restaurantId)
        {
            var result = await _restaurantRepository.Get(x => x.Id == restaurantId && x.IsActive);

            var dto = AppMapper.Map<RestaurantDto>(result);

            return dto;
        }

        public async Task<bool> RemoveRestaurant(RestaurantDto restaurant)
        {
            restaurant.IsActive = false;

            await UpdateRestaurant(restaurant);

            return true;
        }

        public async Task<RestaurantDto> SaveRestaurant(RestaurantDto restaurant)
        {
            var entity = AppMapper.Map<Restauranti.Entities.Models.Restaurant>(restaurant);

            var result = await _restaurantRepository.Insert(entity);

            restaurant.Id = result;

            return restaurant;
        }

        public async Task<RestaurantDto> UpdateRestaurant(RestaurantDto restaurant)
        {
            var entity = AppMapper.Map<Restauranti.Entities.Models.Restaurant>(restaurant);

            await _restaurantRepository.Update(entity);

            return restaurant;
        }
    }
}
