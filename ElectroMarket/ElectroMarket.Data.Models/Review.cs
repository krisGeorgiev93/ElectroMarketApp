using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMarket.Data.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int Rating { get; set; }

        public string ReviewComment { get; set; } = null!;

        public Guid GuestId { get; set; }

        [ForeignKey(nameof(GuestId))]
        public ApplicationUser Guest { get; set; } = null!;

        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        public DateTime DateOfCreation { get; set; }
    }
}
