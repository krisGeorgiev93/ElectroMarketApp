using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroMarket.Data.Migrations
{
    public partial class UpdateDataSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("02c136c1-da74-43e1-bf76-c38a47b9e207"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59bb9654-afbe-490e-8e19-b777ba91f232", "AQAAAAEAACcQAAAAEGBCV/edmb4yVUZdiohIsPoeWUv1aPXvL1j0/AXpTjPhXkDVrgOeaXloV4QugKA88Q==" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("a87fadc6-bf60-4588-9be3-a983925ba502"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7675551b-695f-4970-9945-0d0fa9b06655", "AQAAAAEAACcQAAAAEPgEfhc84SQZGLPBPMcSGbbmpFbBfATPHXv+ceInftfzD6lWqscHJyJfPUr/ODH58w==" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ApplicationUserId", "BrandId", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("d51019ee-1cbf-41f6-84b1-7b5618bc93f9"), null, 1, 4, "Philips 60W LED A60 E27 Light Bulb", "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcTl9RUhMwxf-PE2XRvWYcbOnQwhPzLTVy5H5LnKQocA3cn7HUJYk4zY7ww9iSgvoQELascN0TdYDEdjzcrfprZPFcNe2apH8mKiycZA8f4NeUFRv-cgwP1QCg", 5.5, "Light Bulb Philips" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d51019ee-1cbf-41f6-84b1-7b5618bc93f9"));

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("02c136c1-da74-43e1-bf76-c38a47b9e207"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b097cf7-fa9d-49d5-b2da-e99a274f22e0", "AQAAAAEAACcQAAAAEMeBxwSfkLCbMedNV1zBWokQ18Qh3ioMWsc/7XL6iKbr4quBkL/kMLvRueolpSS11Q==" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("a87fadc6-bf60-4588-9be3-a983925ba502"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7eea57a2-06d1-4e4b-ae24-c5c5162b59f2", "AQAAAAEAACcQAAAAEF5HN/867OcDvxfUYsIhzmd0Cwv1vLH6lwaQYkKxEH/rQxUKpRzKH/kU7cV24vc8Hg==" });
        }
    }
}
