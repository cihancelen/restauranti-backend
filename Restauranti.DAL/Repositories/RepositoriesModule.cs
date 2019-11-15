using System;
using Microsoft.Extensions.DependencyInjection;
using Restauranti.DAL.Repositories.Abstract;
using Restauranti.DAL.Repositories.Abstract.Category;
using Restauranti.DAL.Repositories.Abstract.Restaurant;
using Restauranti.DAL.Repositories.Concrete;
using Restauranti.DAL.Repositories.Concrete.Category;
using Restauranti.DAL.Repositories.Concrete.Restaurant;

namespace Restauranti.DAL.Repositories
{
    public class RepositoriesModule
    {
        public RepositoriesModule(IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IRestaurantRepository, RestaurantRepository>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
