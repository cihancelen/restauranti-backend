using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.DataAccess.Repositories.Abstract;
using Restauranti.Entities.Models;
using Restauranti.DataAccess.Helpers;
using Dapper;

namespace Restauranti.DataAccess.Repositories.Concrete
{
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {
         public async Task<Restaurant> GetRestaurant(Restaurant restaurant)
        {
            var result = await GetAsync(restaurant.Id);

            return result;
        }

        public async Task<List<Restaurant>> GetRestaurants()
        {
            var result = await GetAllAsync(new { IsActive = true });

            return result.AsList();
        }

        public async Task<long> SaveRestaurant(Restaurant restaurant)
        {
            var result = await InsertAsync(restaurant);

            return result;
        }
    }
}
