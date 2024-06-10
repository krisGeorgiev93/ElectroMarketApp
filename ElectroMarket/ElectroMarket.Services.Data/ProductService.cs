using ElectroMarket.Data;
using ElectroMarket.Data.Models;
using ElectroMarket.Services.Data.Interfaces;
using ElektroMarket.Web.ViewModels.Product;

namespace ElectroMarket.Services.Data
{
    public class ProductService : IProductService
    {
        private readonly ElectroMarketDbContext dbContext;
        private readonly IPhotoService photoService;

        public ProductService(ElectroMarketDbContext dbContext, IPhotoService photoService)
        {
            this.dbContext = dbContext;
            this.photoService = photoService;
        }

        public async Task AddProductAsync(ProductFormModel productFormModel)
        {
           var photo = await this.photoService.AddPhotoAsync(productFormModel.Image);

            Product product = new Product()
            {
                Title = productFormModel.Title,
                Description = productFormModel.Description,
                Price = productFormModel.Price,
                ImageUrl = photo.Url.ToString(),
                BrandId = productFormModel.BrandId,
                CategoryId = productFormModel.CategoryId
            };

            await this.dbContext.Products.AddAsync(product);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
