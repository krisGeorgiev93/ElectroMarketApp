using ElectroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectroMarket.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            var categories = new List<Category>();

            var category1 = new Category()
            {
                Id = 1,
                Name = "TV's"
            };

            categories.Add(category1);

            var category2 = new Category()
            {
                Id = 2,
                Name = "Phones"
            };

            categories.Add(category2);

            var category3 = new Category()
            {
                Id = 3,
                Name = "Laptops"
            };

            categories.Add(category3);

            var category4 = new Category()
            {
                Id = 4,
                Name = "Electronics"
            };

            categories.Add(category4);

            return categories;
        }
    }
}
