namespace ElektroMarket.Web.ViewModels.Product
{
    public class PaginationViewModel
    {
        public PaginationViewModel()
        {
            this.ItemsPerPage = 10;
        }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
    }
}
