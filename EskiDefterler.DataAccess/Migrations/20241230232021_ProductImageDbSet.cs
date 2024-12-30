using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EskiDefterler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductImageDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Products_ProductId",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Carts_ProductId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Products_ProductId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "CartProducts");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                newName: "ProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_ProductId",
                table: "CartProducts",
                newName: "IX_CartProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_Id",
                table: "CartProducts",
                newName: "IX_CartProducts_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_Id",
                table: "ProductImages",
                newName: "IX_ProductImages_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Carts_ProductId",
                table: "CartProducts",
                column: "ProductId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Products_ProductId",
                table: "CartProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Carts_ProductId",
                table: "CartProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Products_ProductId",
                table: "CartProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductImage");

            migrationBuilder.RenameTable(
                name: "CartProducts",
                newName: "Sales");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImage",
                newName: "IX_ProductImage_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_Id",
                table: "ProductImage",
                newName: "IX_ProductImage_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartProducts_ProductId",
                table: "Sales",
                newName: "IX_Sales_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartProducts_Id",
                table: "Sales",
                newName: "IX_Sales_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Products_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
