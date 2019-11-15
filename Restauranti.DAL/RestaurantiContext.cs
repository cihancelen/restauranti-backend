using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Restauranti.Entities.Models;
using Restauranti.Entities.Models.Relations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Restauranti.Entities.Models.Authentication;

namespace Restauranti.DAL
{
    public class RestaurantiContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public RestaurantiContext(DbContextOptions<RestaurantiContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProductUnits>()
                .HasKey(x => new { x.ProductId, x.UnitId });

            builder.Entity<ProductMenus>()
                .HasKey(x => new { x.ProductId, x.MenuId });
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Unit> Units { get; set; }

        public DbSet<RestaurantClient> RestaurantClients { get; set; }

        public DbSet<Menu> Menus { get; set; }

    }
}
