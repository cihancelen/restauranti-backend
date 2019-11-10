using System;
using Microsoft.Extensions.DependencyInjection;
using Restauranti.BLL.Services.Abstract.Restaurant;
using Restauranti.BLL.Services.Concrete.Restaurant;

namespace Restauranti.BLL.Services
{
    public class ServicesModule
    {
        public ServicesModule(IServiceCollection services)
        {
            services.AddScoped<IRestaurantService, RestaurantService>();
        }
    }
}
