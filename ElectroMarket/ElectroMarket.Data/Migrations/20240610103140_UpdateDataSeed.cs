using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroMarket.Data.Migrations
{
    public partial class UpdateDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "ApplicationUser");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("02c136c1-da74-43e1-bf76-c38a47b9e207"), 0, "7b097cf7-fa9d-49d5-b2da-e99a274f22e0", "krisko@mail.com", false, "Kristiyan", "Georgiev", false, null, "krisko@mail.com", "krisko@mail.com", "AQAAAAEAACcQAAAAEMeBxwSfkLCbMedNV1zBWokQ18Qh3ioMWsc/7XL6iKbr4quBkL/kMLvRueolpSS11Q==", null, false, null, null, false, "krisko@mail.com" },
                    { new Guid("a87fadc6-bf60-4588-9be3-a983925ba502"), 0, "7eea57a2-06d1-4e4b-ae24-c5c5162b59f2", "ivan@mail.com", false, "Ivan", "Ivanov", false, null, "ivan@mail.com", "ivan@mail.com", "AQAAAAEAACcQAAAAEF5HN/867OcDvxfUYsIhzmd0Cwv1vLH6lwaQYkKxEH/rQxUKpRzKH/kU7cV24vc8Hg==", null, false, null, null, false, "ivan@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Philips" },
                    { 2, "Dell" },
                    { 3, "Samsung" },
                    { 4, "LG" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TV's" },
                    { 2, "Phones" },
                    { 3, "Laptops" },
                    { 4, "Electronics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("02c136c1-da74-43e1-bf76-c38a47b9e207"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("a87fadc6-bf60-4588-9be3-a983925ba502"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "ApplicationUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
