namespace ElektroMarket.Web.ViewModels.Product
{
    public class AllProductsViewModel
    {
        public string Title { get; set; } 
        
        public string Description { get; set; } 

        public double Price { get; set; }
        
        public string ImageUrl { get; set; }
                
        public string Brand { get; set; }
      
        public string Category { get; set; }
    }
    public class ProductsPageViewModel
    {
        public List<AllProductsViewModel> Products { get; set; } = new List<AllProductsViewModel>();
        public PaginationViewModel Pagination { get; set; }
    }
}
