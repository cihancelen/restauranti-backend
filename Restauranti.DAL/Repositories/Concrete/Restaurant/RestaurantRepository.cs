using System.Threading.Tasks;
using Restauranti.DAL.Repositories.Abstract;
using Restauranti.DAL.Repositories.Abstract.Restaurant;
using Restauranti.Entities.Models;

namespace Restauranti.DAL.Repositories.Concrete.Restaurant
{
    public class RestaurantRepository : BaseRepository<Entities.Models.Restaurant>, IRestaurantRepository
    {
        
    }
}
