namespace ElectroMarket.Services.Data.Interfaces
{
    using ElektroMarket.Web.ViewModels.Category;
    public interface ICategoryService
    {
        Task<IEnumerable<SelectCategoryFormModel>> GetAllCategoriesAsync();
       
    }
}
