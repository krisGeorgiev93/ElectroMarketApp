using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroMarket.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8099b56d-7710-415d-9c06-4569082c6758"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85d863ec-44e3-4b93-a689-da817f5cf434", "AQAAAAEAACcQAAAAED+BEEHA6lSVYCdbyNKgX1WC1MgC54CYKCKCh/q+g+vngfN3nLgmfU7uqIB6VJtGSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faf6dc41-ce01-44a9-b63c-0abd2df2d15f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "143e0823-789d-4195-a34b-c0fd5146ade7", "AQAAAAEAACcQAAAAEN6E1AsfEj2DGC2SkYrf9VKhabpPBjsUmv/7bjX7+TNe7l8AccYPzrX2WlP+Cg1ALg==" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AppUserId", "BrandId", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("7acbad8c-34af-4a9d-a6f0-0f65e07d8c23"), null, 1, 1, "Take amazing photos in the dimmest of settings with the Galaxy's incredible triple rear camera setup.", "https://media.currys.biz/i/currysprod/10259965?$l-large$&fmt=auto", 500.0, "Galaxy S24 Ultra" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7acbad8c-34af-4a9d-a6f0-0f65e07d8c23"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8099b56d-7710-415d-9c06-4569082c6758"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5112d626-7502-4880-90e9-76391188d099", "AQAAAAEAACcQAAAAENEOSRAS6EQ9HOvHd1oJ9HBwGapjuD+pstgHS9HFgCjcRnFXhqeio7FjZTZ8PMKYvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faf6dc41-ce01-44a9-b63c-0abd2df2d15f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32d1b04e-790a-4fb8-a2a5-679884e7f46b", "AQAAAAEAACcQAAAAENMROwzE5N/lpeCKWyibV3inXXuwIiyXPjfZpaZMVhdVptQaZgkYyoSsPrcGOzDmkw==" });
        }
    }
}
