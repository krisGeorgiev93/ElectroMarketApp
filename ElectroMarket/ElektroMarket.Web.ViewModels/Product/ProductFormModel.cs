using ElektroMarket.Web.ViewModels.Brand;
using ElektroMarket.Web.ViewModels.Category;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using static ElectroMarket.Common.ValidationConstants.Product;
namespace ElektroMarket.Web.ViewModels.Product
{
    public class ProductFormModel
    {
        public ProductFormModel()
        {
            this.Brands = new HashSet<SelectBrandFormModel>();
            this.Categories = new HashSet<SelectCategoryFormModel>();
        }
        public Guid Id { get; set; }

        [Required]
        [MinLength(titleMinLength)]
        [MaxLength(titleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MinLength(descriptionMinLength)]
        [MaxLength(descriptionMaxLength)]
        public string Description { get; set; } = null!;

        public double Price { get; set; }

        [Required]
        public IFormFile Image { get; set; } = null!;

        [Required]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
       
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectBrandFormModel> Brands { get; set; }

        public IEnumerable<SelectCategoryFormModel> Categories { get; set; }

    }
}
