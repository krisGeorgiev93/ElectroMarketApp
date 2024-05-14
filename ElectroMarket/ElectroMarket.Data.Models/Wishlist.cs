using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMarket.Data.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        public Guid AppUserId { get; set; }

        [ForeignKey(nameof(AppUserId))]
        public ApplicationUser AppUser { get; set; }
        public ICollection<WishlistProduct> WishlistProducts { get; set; } = new List<WishlistProduct>();
    }
}
