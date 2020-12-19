using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restauranti.Dto.Models.Restaurant;
using Microsoft.AspNetCore.Authorization;
using Restauranti.BLL.Services.Abstract.Restaurant;

namespace Restauranti.Api.Controllers.Restaurant
{
    public class RestaurantController : BaseController<IRestaurantService, RestaurantDto>
    {
        public RestaurantController(IRestaurantService service) : base(service)
        { }

        [Route("test")]
        [HttpGet]
        public string Test()
        {
            return "Helllo";
        }
    }
}
