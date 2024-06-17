using ElectroMarket.Data;
using ElectroMarket.Data.Models;
using ElectroMarket.Services.Data.Interfaces;
using ElektroMarket.Web.ViewModels.Product;
using Microsoft.EntityFrameworkCore;

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

        public async Task DeleteProductAsync(string id)
        {
            var productForDelete = await dbContext.Products.FirstAsync(p => p.Id.ToString() == id);
            if (productForDelete != null)
            {
                dbContext.Products.Remove(productForDelete);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Product not found.");
            }
        }

       

        public async Task<IEnumerable<AllProductsViewModel>> GetAllProductsAsync()
        {
            return dbContext.Products
               .Select(p => new AllProductsViewModel
               {
                   Id = p.Id,
                   Title = p.Title,
                   Description = p.Description,
                   Price = p.Price,
                   ImageUrl = p.ImageUrl,
                   Brand = p.Brand.Name,
                   Category = p.Category.Name
               }).ToList();
        }

        public async Task<ProductFormModel> GetProductByIdAsync(string id)
        {
           var product = await this.dbContext.Products.FirstAsync(p=> p.Id.ToString() == id);

            if (product == null)
            {
                throw new InvalidOperationException("Product not found.");
            }

            var productForm = new ProductFormModel
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price,
            };
            return productForm;
        }

        public async Task<bool> ProductExistsByIdAsync(string id)
        {
            bool isExist = await this.dbContext.Products.AnyAsync(p => p.Id.ToString() == id);
            return isExist;
        }
    }
}
