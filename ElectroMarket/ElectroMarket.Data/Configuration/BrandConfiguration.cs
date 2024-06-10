using ElectroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMarket.Data.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(CreateBrands());
        }

        private List<Brand> CreateBrands()
        {
            var brands = new List<Brand>();

            var brand1 = new Brand()
            {
                Id = 1,
                Name = "Philips",
            };

            brands.Add(brand1);

            var brand2 = new Brand()
            {
                Id = 2,
                Name = "Dell",
            };

            brands.Add(brand2);

            var brand3 = new Brand()
            {
                Id = 3,
                Name = "Samsung",
            };

            brands.Add(brand3);

            var brand4 = new Brand()
            {
                Id = 4,
                Name = "LG",
            };

            brands.Add(brand4);

            return brands;
        }
    }
}
