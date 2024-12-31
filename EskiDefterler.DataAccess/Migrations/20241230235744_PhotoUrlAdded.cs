using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EskiDefterler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PhotoUrlAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "https://ideacdn.net/idea/ce/36/myassets/products/164/img-e5560.JPG?revision=1720098706");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "https://s3.cloud.ngn.com.tr/kitantik/images/2024-06-12/1br9qfwlxbwuygk13hk.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoUrl",
                value: "https://www.plakperest.com/img/products/16742102032787432570614927694837_20.01.2023_a1433d3.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Products");
        }
    }
}
