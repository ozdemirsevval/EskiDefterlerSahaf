using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EskiDefterler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false, defaultValueSql: "GETDATE()"),
                    Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleTitle = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false, defaultValueSql: "GETDATE()"),
                    Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    StockQuantity = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    AddressDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    District = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "GETDATE()"),
                    RequiredDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ShippedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Freight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ShipperId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Shippers_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shippers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Kitap" },
                    { 2, "Walkmen" },
                    { 3, "Pikap" },
                    { 4, "Kaset" },
                    { 5, "Plak" },
                    { 6, "DVD" },
                    { 7, "CD" },
                    { 8, "İmzalı Ürünler" },
                    { 9, "Diğerleri" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "RoleTitle" },
                values: new object[,]
                {
                    { 1, "Customer" },
                    { 2, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "Id", "CompanyName", "Phone" },
                values: new object[,]
                {
                    { 1, "JetKargo", "+90 555 444 55 55" },
                    { 2, "Aras Kargo", "444 25 52" },
                    { 3, "PTT Kargo", "+90 312 309 51 44" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Aşk ve Romantik" },
                    { 2, 1, "Bilim Kurgu" },
                    { 3, 1, "Biyogrofi ve Otobiyografi" },
                    { 4, 1, "Bilim ve Araştırma" },
                    { 5, 1, "Deneme ve Makale" },
                    { 6, 1, "Ders Kitapları" },
                    { 7, 1, "Fantastik ve Mitoloji" },
                    { 8, 1, "Gerilim" },
                    { 9, 1, "Hobi ve İlgi Alanları" },
                    { 10, 1, "Kişisel Gelişim" },
                    { 11, 1, "Macera" },
                    { 12, 1, "Öykü" },
                    { 13, 1, "Polisiye" },
                    { 14, 1, "Roman" },
                    { 15, 1, "Şiir" },
                    { 16, 1, "Sözlük ve Ansiklopediler" },
                    { 17, 1, "Tarih" },
                    { 18, 1, "Tiyatro" },
                    { 19, 3, "Alternatif Rock" },
                    { 20, 3, "Blues" },
                    { 21, 3, "Caz(Jazz)" },
                    { 22, 3, "Country" },
                    { 23, 3, "Dans" },
                    { 24, 3, "Elektronik" },
                    { 25, 3, "Folk" },
                    { 26, 3, "Funk" },
                    { 27, 3, "Gospel" },
                    { 28, 3, "Hard Rock" },
                    { 29, 3, "Heavy Metal" },
                    { 30, 3, "Hip-Hop" },
                    { 31, 3, "Indie" },
                    { 32, 3, "Klasik" },
                    { 33, 3, "Latin" },
                    { 34, 3, "New Age" },
                    { 35, 3, "Opera" },
                    { 36, 3, "Pop" },
                    { 37, 3, "Punk" },
                    { 38, 3, "R&B" },
                    { 39, 3, "Rap" },
                    { 40, 3, "Reggae" },
                    { 41, 3, "Rock" },
                    { 42, 3, "Soul" },
                    { 43, 3, "Tekno" },
                    { 44, 3, "Trap" },
                    { 45, 3, "Türk Halk Müziği" },
                    { 46, 3, "Türk Sanat Müziği" },
                    { 47, 3, "World Music" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { 1, new DateOnly(1977, 9, 15), "tomhardy@gmail.com", "Tom", "Hardy", "qweasd", "+90 555 555 55 55", 1 },
                    { 2, new DateOnly(2002, 12, 17), "furkan_yeneroğlu@gmail.com", "Furkan", "Yeneroğlu", "qweasd", "+90 555 555 55 44", 1 },
                    { 3, new DateOnly(2002, 10, 21), "iremozyurt@gmail.com", "İrem Nur", "Özyurt", "qweasd", "+90 555 555 55 34", 1 },
                    { 4, new DateOnly(2005, 10, 4), "ildemcakici@gmail.com", "İldem", "Çakıcı", "qweasd", "+90 555 555 54 34", 1 },
                    { 5, new DateOnly(1983, 5, 5), "henrycavill@gmail.com", "Henry", "Cavill", "qweasd", "+90 555 555 33 55", 1 },
                    { 6, new DateOnly(2002, 11, 24), "sevval@admin.com", "Şevval", "Özdemir", "qweasd", "+90 555 555 51 34", 2 },
                    { 7, new DateOnly(1, 1, 1), "ercan@admin.com", "Ercan", "Öztürk", "qweasd", "+90 555 555 55 24", 2 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressDescription", "AddressName", "District", "Province", "UserId" },
                values: new object[,]
                {
                    { 1, "Sevgi Caddesi,Susam Sokağı, Minik Kuş Apartmanı No:13 / Daire:2", "Home", "Kadıköy", "İstanbul", 1 },
                    { 2, "Gökçe Mahallesi, Yıldız Apartmanı No:21 Daire:7", "Office", "Mustafakemalpaşa", "Bursa", 2 },
                    { 3, "Kutlu Sokak, Doğan Apt. No:12 Daire:1", "Evim", "Karşıyaka", "İzmir", 3 },
                    { 4, "Perihan Mahallesi, Savaş Sokak, Çiçek Apt. No:12 Daire:9", "Annemler", "Maltepe", "İstanbul", 4 },
                    { 5, "Balıkesir Mh. , Perdane Sokak, Özdemir Sitesi B Blok Daire:13", "MyHome", "Çankaya", "Ankara", 5 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Condition", "Description", "Price", "StockQuantity", "SubCategoryId", "Title" },
                values: new object[,]
                {
                    { 1, "Yeni Gibi", "Ada Müzk Yapım şirketi imzalı 99 çıkışlı albümü", 200m, 1, 36, "1999 Bülent Ortaçgil - Eski Defterler Kaseti" },
                    { 2, "İkinci el", "Cem Yayınları, 1971. Karton Kapak", 100m, 2, 14, "İnce Memed II" },
                    { 3, "İkinci El", "Yönetmen: Yann Samuell Oyuncular: Guillaume Canet, Marion Cotillard, Thibault VerhaegheÖzet: Sophie ve Julien, çocukluklarından bu yana bir “cesaret oyunuyla” birbirlerine bağlanmış iki arkadaştır. Aradan geçen zaman, ikilinin arasına giren insanlar, kızgınlıklar ve hayal kırıklıkları, hepsi oyunun aşılması gereken engellerine dönüşür. Kahramanlarımızın arasında hayal gücünün sınırlarını zorlayan bir aşk yaratan bu oyun, maalesef kavuşmalarını da engeller. Şimdi bu iki genç aşığın önündeki son ve en zorlu görev, aşklarını yaratan bu yıkıcı oyunla başa çıkarak, bir arada olmayı öğrenmektir.", 25m, 1, 1, "Cesaretin var mı aşka?" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "Freight", "OrderDate", "RequiredDate", "ShippedDate", "ShipperId", "UserId" },
                values: new object[] { 1, 1, 0m, new DateOnly(2024, 10, 18), new DateOnly(2024, 10, 22), new DateOnly(2024, 10, 20), 0, 3 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "Discount", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { 1, 0m, 1, 1, 1, 200m });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Id",
                table: "Addresses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Id",
                table: "Carts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Id",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Id",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id",
                table: "Orders",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperId",
                table: "Orders",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Id",
                table: "Role",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleTitle",
                table: "Role",
                column: "RoleTitle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Id",
                table: "Sales",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shippers_Id",
                table: "Shippers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shippers_Phone",
                table: "Shippers",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Id",
                table: "SubCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
