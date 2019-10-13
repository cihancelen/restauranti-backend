﻿using System;
using Microsoft.EntityFrameworkCore;
using Restauranti.Entities.Models;
using Restauranti.Entities.Models.Relations;

namespace Restauranti.Entities
{
    public class RestaurantiContext : DbContext
    {
        public RestaurantiContext(DbContextOptions<RestaurantiContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductUnits>()
                .HasKey(x => new { x.ProductId, x.UnitId });

            modelBuilder.Entity<ProductMenus>()
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