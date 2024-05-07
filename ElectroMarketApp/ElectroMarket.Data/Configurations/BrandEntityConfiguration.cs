using ElectroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectroMarket.Data.Configurations
{
    public class BrandEntityConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(this.UploadBrands());
        }
        private Brand[] UploadBrands()
        {
            ICollection<Brand> brands = new HashSet<Brand>();

            Brand brand;

            brand = new Brand()
            {
                Id = 1,
                Name = "Samsung"
            };
            brands.Add(brand);

            brand = new Brand()
            {
                Id = 2,
                Name = "Apple"
            };
            brands.Add(brand);

            return brands.ToArray();
        }
    }
}
