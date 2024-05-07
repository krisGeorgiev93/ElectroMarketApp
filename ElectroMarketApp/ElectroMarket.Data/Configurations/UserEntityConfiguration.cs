using ElectroMarket.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectroMarket.Data.Configurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(SeedUsers());
        }

        private List<AppUser> SeedUsers()
        {
            AppUser user;
            var users = new List<AppUser>();
            var hasher = new PasswordHasher<AppUser>();

            user = new AppUser()
            {
                Id = Guid.Parse("faf6dc41-ce01-44a9-b63c-0abd2df2d15f"),
                FirstName = "Kristiyan",
                LastName = "Georgiev",
                BirthDate = DateTime.Parse("05/11/1990"),
                UserName = "krisko@mail.com",
                NormalizedUserName = "krisko@mail.com",
                Email = "krisko@mail.com",
                NormalizedEmail = "krisko@mail.com"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            users.Add(user);

            user = new AppUser()
            {
                Id = Guid.Parse("8099b56d-7710-415d-9c06-4569082c6758"),
                FirstName = "Ivan",
                LastName = "Ivanov",
                BirthDate = DateTime.Parse("10/09/1995"),
                UserName = "ivan@mail.com",
                NormalizedUserName = "ivan@mail.com",
                Email = "ivan@mail.com",
                NormalizedEmail = "ivan@mail.com"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            users.Add(user);

            return users;
        }
    }
}
