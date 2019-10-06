using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.DataAccess.Repositories.Concrete;
using Restauranti.Entities.Models;

namespace Restauranti.DataAccess.Repositories.Abstract
{
    public interface IRestaurantRepository
    {
        Task<Restaurant> GetRestaurant(Restaurant restaurant);

        Task<List<Restaurant>> GetRestaurants();

        Task<long> SaveRestaurant(Restaurant restaurant);
    }
}
