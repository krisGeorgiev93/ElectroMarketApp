using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroMarket.Data.Migrations
{
    public partial class AddPhotoCloudinarySettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("02c136c1-da74-43e1-bf76-c38a47b9e207"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f37b8a8-3446-4c6e-93d9-b8f8f4ab2bea", "AQAAAAEAACcQAAAAEF20Y/tiU4m5VuUm4Z4ZF1s3ggee1mV2T/050RccPqnziXcS283x6qUU6G0wolFe+w==" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("a87fadc6-bf60-4588-9be3-a983925ba502"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e86a7519-461f-469a-9017-954c9ec8e811", "AQAAAAEAACcQAAAAEN16B85cV0pDYNiq9qzKkemvRdzoSODP0WAi1m9ZCxq+Ocx6CTjN9O6DPhDCl0xp6w==" });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId",
                table: "Photos",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

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
        }
    }
}
