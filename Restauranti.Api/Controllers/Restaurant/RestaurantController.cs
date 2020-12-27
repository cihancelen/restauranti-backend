using Restauranti.Dto.Models.Restaurant;
using Restauranti.BLL.Services.Abstract.Restaurant;

namespace Restauranti.Api.Controllers.Restaurant
{
    public class RestaurantController : BaseController<IRestaurantService, RestaurantDto>
    {
        public RestaurantController(IRestaurantService service) : base(service)
        { }
    }
}
