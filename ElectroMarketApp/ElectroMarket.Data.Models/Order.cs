using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectroMarket.Data.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public  AppUser User { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
