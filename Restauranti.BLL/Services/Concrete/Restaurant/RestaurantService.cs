using System.Threading.Tasks;
using Restauranti.Dto.Models.Restaurant;
using Restauranti.Service.Helpers;
using System.Collections.Generic;
using Restauranti.DAL.Repositories.Abstract.Restaurant;
using Restauranti.BLL.Services.Abstract.Restaurant;
using Restauranti.BLL.Services.Concrete.Base;

namespace Restauranti.BLL.Services.Concrete.Restaurant
{
    public class RestaurantService : BaseService<IRestaurantRepository, Restauranti.Entities.Models.Restaurant, RestaurantDto>, IRestaurantService
    {
        public RestaurantService(IRestaurantRepository repository) : base(repository)
        { }
    }
}
