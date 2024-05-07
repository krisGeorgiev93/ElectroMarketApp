namespace ElectroMarket.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
            this.Id = Guid.NewGuid();
        }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }

        public ICollection<Product> FavoriteProducts { get; set; }

        public Guid? ShoppingCartId { get; set; }

        [ForeignKey(nameof(ShoppingCartId))]
        public ShoppingCart? ShoppingCart { get; set; }

    }
}
