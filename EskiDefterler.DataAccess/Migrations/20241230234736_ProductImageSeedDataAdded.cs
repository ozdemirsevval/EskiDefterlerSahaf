using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EskiDefterler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductImageSeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "PhotoPath", "PhotoTitle", "ProductId" },
                values: new object[,]
                {
                    { 1, "https://ideacdn.net/idea/ce/36/myassets/products/164/img-e5560.JPG?revision=1720098706", "Ortaçgil", 1 },
                    { 2, "https://s3.cloud.ngn.com.tr/kitantik/images/2024-06-12/1br9qfwlxbwuygk13hk.jpg", "İnceMemed", 2 },
                    { 3, "https://www.plakperest.com/img/products/16742102032787432570614927694837_20.01.2023_a1433d3.jpg", null, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
