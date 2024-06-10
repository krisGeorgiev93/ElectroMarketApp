using ElectroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectroMarket.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.IsActive)
                .HasDefaultValue(true);

            builder.HasData(CreateProducts());
        }

        private List<Product> CreateProducts()
        {
            var products = new List<Product>();

            var product1 = new Product()
            {
                Id = Guid.Parse("d51019ee-1cbf-41f6-84b1-7b5618bc93f9"),
                Title = "Light Bulb Philips",
                Description = "Philips 60W LED A60 E27 Light Bulb",
                Price = 5.50,
                ImageUrl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcTl9RUhMwxf-PE2XRvWYcbOnQwhPzLTVy5H5LnKQocA3cn7HUJYk4zY7ww9iSgvoQELascN0TdYDEdjzcrfprZPFcNe2apH8mKiycZA8f4NeUFRv-cgwP1QCg",
                BrandId = 1,
                CategoryId = 4
            };

            return products;
        }
    }
}
