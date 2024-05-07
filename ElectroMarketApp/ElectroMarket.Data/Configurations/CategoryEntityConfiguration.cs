using ElectroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectroMarket.Data.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.UploadCategories());
        }

        private Category[] UploadCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category()
            {
                Id = 1,
                Name = "Smart Phones"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Laptops"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}