using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMarket.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public double Price { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        public int BrandId { get; set; }

        [ForeignKey(nameof(BrandId))]
        public Brand Brand { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public ICollection<Review> Reviews { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = null!;

        public ICollection<WishlistProduct> WishlistProducts { get; set; } = new List<WishlistProduct>();
    }
}
