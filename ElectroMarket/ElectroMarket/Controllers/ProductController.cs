using ElectroMarket.Data;
using ElectroMarket.Services.Data.Interfaces;
using ElektroMarket.Web.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace ElectroMarket.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IBrandService brandService;
        private readonly IPhotoService photoService;
        private readonly ElectroMarketDbContext dbContext;

        public ProductController(IProductService productService, ICategoryService categoryService, IBrandService brandService, IPhotoService photoService, ElectroMarketDbContext dbContext)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.brandService = brandService;
            this.photoService = photoService;
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ProductFormModel model = new ProductFormModel()
            {
                Categories = await this.categoryService.GetAllCategoriesAsync(),
                Brands = await this.brandService.GetAllBrandsAsync()
            };            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.productService.AddProductAsync(model);

            return RedirectToAction("All", "Product");
        }
    }
}
