using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectroMarket.Data.Models
{
    public class ShoppingCart
    {
        [Key]
        public Guid Id { get; set; }               
                      
        [Required]
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
    }
}
