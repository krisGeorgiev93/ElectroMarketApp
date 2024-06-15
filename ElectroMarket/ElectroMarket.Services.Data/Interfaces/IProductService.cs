using ElektroMarket.Web.ViewModels.Product;

namespace ElectroMarket.Services.Data.Interfaces
{
    public interface IProductService
    {
        Task AddProductAsync(ProductFormModel productFormModel);

        Task<IEnumerable<AllProductsViewModel>> GetAllProductsAsync();


    }
}
