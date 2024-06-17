using ElectroMarket.Data.Models;
using ElektroMarket.Web.ViewModels.Product;

namespace ElectroMarket.Services.Data.Interfaces
{
    public interface IProductService
    {
        Task AddProductAsync(ProductFormModel productFormModel);

        Task<IEnumerable<AllProductsViewModel>> GetAllProductsAsync();

        Task DeleteProductAsync(string id);

        Task<bool> ProductExistsByIdAsync(string id);

        Task<ProductFormModel> GetProductByIdAsync(string id);



    }
}
