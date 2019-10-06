using System;
using Microsoft.EntityFrameworkCore;

using Restauranti.Entities.Models;

namespace Restauranti.DataAccess
{
    public class RestaurantiContext: DbContext
    {
        public RestaurantiContext(DbContextOptions<RestaurantiContext> dbContextOptions): base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

    }
}
