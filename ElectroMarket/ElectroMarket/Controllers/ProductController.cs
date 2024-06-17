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

        [HttpGet]
        public async Task<IActionResult> All(int page = 1, int itemsPerPage = 10)
        {
            var allProducts = await productService.GetAllProductsAsync();

            var totalItems = allProducts.Count();
            var totalPages = (int)Math.Ceiling(totalItems / (double)itemsPerPage);

            var productsToDisplay = allProducts
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Select(p => new AllProductsViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                    Brand = p.Brand,
                    Category = p.Category
                }).ToList();

            var viewModel = new ProductsPageViewModel
            {
                Products = productsToDisplay,
                Pagination = new PaginationViewModel
                {
                    CurrentPage = page,
                    TotalPages = totalPages,
                    TotalItems = totalItems,
                    ItemsPerPage = itemsPerPage
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            bool productExists = await this.productService.ProductExistsByIdAsync(id);

            if (!productExists)
            {
                throw new Exception("This product does not exists");
            }

            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            await productService.DeleteProductAsync(id);

            return RedirectToAction("All");
        }
    }
}
