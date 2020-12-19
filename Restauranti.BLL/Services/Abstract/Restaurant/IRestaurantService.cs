using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.BLL.Services.Abstract.Base;
using Restauranti.DAL.Repositories.Concrete.Restaurant;
using Restauranti.Dto.Models.Restaurant;

namespace Restauranti.BLL.Services.Abstract.Restaurant
{
    public interface IRestaurantService : IBaseService<RestaurantDto>
    {
        
    }
}
