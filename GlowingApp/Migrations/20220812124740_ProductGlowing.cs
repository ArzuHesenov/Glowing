using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlowingApp.Migrations
{
    public partial class ProductGlowing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Id", "CatagoryName", "Icon" },
                values: new object[] { 1, "EyeLiner", "" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Id", "CatagoryName", "Icon" },
                values: new object[] { 2, "HairCream", "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CatagoryId", "Description", "Discount", "IsNew", "Isfeatured", "Name", "PhotoUrl", "Price", "Rating" },
                values: new object[] { 1, 1, "Niacinamide and Vitamin C are two anti-aging superstars but not usually formulated together because of their different pH levels.", 0m, true, true, "Natural Coconut Cleansing Oil", "http://templates.g5plus.net/glowing/images/product-07.jpg", 200m, 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CatagoryId", "Description", "Discount", "IsNew", "Isfeatured", "Name", "PhotoUrl", "Price", "Rating" },
                values: new object[] { 2, 2, "Niacinamide 2 and Vitamin C are two anti-aging superstars but not usually formulated together because of their different pH levels.", 190.99m, false, false, "Natural2", "http://templates.g5plus.net/glowing/images/product-15.jpg", 400m, 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
