using ElectroMarket.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

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

        public DbSet<Wishlist> Wishlists { get; set; }

        public DbSet<WishlistProduct> WishlistProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WishlistProduct>()
        .HasKey(wp => new { wp.WishlistId, wp.ProductId });

            builder.Entity<WishlistProduct>()
                .HasOne(wp => wp.Wishlist)
                .WithMany(w => w.WishlistProducts)
                .HasForeignKey(wp => wp.WishlistId);

            builder.Entity<WishlistProduct>()
                .HasOne(wp => wp.Product)
                .WithMany(p => p.WishlistProducts)
                .HasForeignKey(wp => wp.ProductId);

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

            builder.Entity<Order>()
             .Property(o => o.TotalAmount)
             .HasColumnType("decimal(18,2)");                        

            base.OnModelCreating(builder);
        }
    }
}
