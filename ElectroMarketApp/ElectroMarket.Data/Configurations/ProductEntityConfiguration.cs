using ElectroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectroMarket.Data.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(r => r.IsActive)
                  .HasDefaultValue(true);

            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(), // Generate a new GUID for the Id
                    Title = "Galaxy S24 Ultra",
                    BrandId = 1,
                    CategoryId = 1,
                    Description = "Take amazing photos in the dimmest of settings with the Galaxy's incredible triple rear camera setup.",
                    ImageUrl = "https://media.currys.biz/i/currysprod/10259965?$l-large$&fmt=auto",
                    Price = 500,
                }
            );
        }
    }
}