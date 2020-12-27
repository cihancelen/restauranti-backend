using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Restauranti.DAL
{
    public partial class RestaurantiContext : DbContext
    {
        public RestaurantiContext()
        {
        }

        public RestaurantiContext(DbContextOptions<RestaurantiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<ProductMenus> ProductMenus { get; set; }
        public virtual DbSet<ProductUnits> ProductUnits { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RestaurantClients> RestaurantClients { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost,1433; Database=Restauranti; User Id=sa; Password=!restauranti2020");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.ResturantId).HasDefaultValueSql("(CONVERT([bigint],(0)))");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasIndex(e => e.RestaurantId);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.RestaurantId);
            });

            modelBuilder.Entity<Menus>(entity =>
            {
                entity.HasIndex(e => e.RestaurantId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.RestaurantId);
            });

            modelBuilder.Entity<ProductMenus>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.MenuId });

                entity.HasIndex(e => e.Id)
                    .HasName("AK_ProductMenus_Id")
                    .IsUnique();

                entity.HasIndex(e => e.MenuId);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.ProductMenus)
                    .HasForeignKey(d => d.MenuId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductMenus)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductUnits>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.UnitId });

                entity.HasIndex(e => e.Id)
                    .HasName("AK_ProductUnits_Id")
                    .IsUnique();

                entity.HasIndex(e => e.UnitId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductUnits)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ProductUnits)
                    .HasForeignKey(d => d.UnitId);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.RestaurantId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.RestaurantId);
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.HasIndex(e => e.RestaurantId);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.RestaurantId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.RestaurantId);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RestaurantId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
