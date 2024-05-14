using ElectroMarket.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ElectroMarket.Data
{
    public class ElectroMarketDbContext : IdentityDbContext
    {
        public ElectroMarketDbContext(DbContextOptions<ElectroMarketDbContext> options)
            : base(options)
        {
        }       

        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Review>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ApplicationUser>()
            .HasOne(u => u.ShoppingCart)
            .WithMany()
            .HasForeignKey(u => u.ShoppingCartId)
            .OnDelete(DeleteBehavior.NoAction);

            //Assembly assembly = Assembly.GetAssembly(typeof(ElectroMarketDbContext))
            //   ?? Assembly.GetExecutingAssembly();

            //builder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(builder);
        }
    }
}
