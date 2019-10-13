using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.Entities.Models;

namespace Restauranti.DAL.Repositories.Abstract
{
    public interface IRestaurantRepository
    {
        Task<Restaurant> GetRestaurant(Restaurant restaurant);

        Task<List<Restaurant>> GetRestaurants();

        Task<long> SaveRestaurant(Restaurant restaurant);
    }
}
