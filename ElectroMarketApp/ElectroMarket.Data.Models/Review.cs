using System.ComponentModel.DataAnnotations.Schema;

namespace ElectroMarket.Data.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int Rating { get; set; }

        public string ReviewComment { get; set; }

        public Guid GuestId { get; set; }

        [ForeignKey(nameof(GuestId))]
        public AppUser Guest { get; set; } = null!;

        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        public DateTime DateOfCreation { get; set; }

    }
}
