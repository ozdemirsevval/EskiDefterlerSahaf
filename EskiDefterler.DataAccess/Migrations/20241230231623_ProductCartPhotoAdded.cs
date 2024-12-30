using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EskiDefterler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductCartPhotoAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Carts");

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_Id",
                table: "ProductImage",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Carts_ProductId",
                table: "Sales",
                column: "ProductId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Products_ProductId",
                table: "Sales",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Carts_ProductId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Products_ProductId",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ProductId",
                table: "Sales");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "datetime2",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Sales",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Sales",
                type: "decimal(18,2)",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Carts",
                type: "datetime2",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Carts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Carts",
                type: "decimal(18,2)",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Carts",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
