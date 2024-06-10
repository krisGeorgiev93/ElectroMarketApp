using ElectroMarket.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMarket.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var user1 = new ApplicationUser()
            {
                Id = Guid.Parse("02c136c1-da74-43e1-bf76-c38a47b9e207"),
                UserName = "krisko@mail.com",
                NormalizedUserName = "krisko@mail.com",
                Email = "krisko@mail.com",
                NormalizedEmail = "krisko@mail.com",
            };

            user1.PasswordHash =
                 hasher.HashPassword(user1, "123456");

            users.Add(user1);

            var user2 = new ApplicationUser()
            {
                Id = Guid.Parse("a87fadc6-bf60-4588-9be3-a983925ba502"),
                UserName = "ivan@mail.com",
                NormalizedUserName = "ivan@mail.com",
                Email = "ivan@mail.com",
                NormalizedEmail = "ivan@mail.com",
            };

            user2.PasswordHash =
                 hasher.HashPassword(user2, "123456");

            users.Add(user2);

            return users;
        }

    }
}
