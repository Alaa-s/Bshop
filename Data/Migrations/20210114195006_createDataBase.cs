using Microsoft.EntityFrameworkCore.Migrations;

namespace bakaryshop.Data.Migrations
{
    public partial class createDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    product_name = table.Column<string>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "description", "ImageFileName", "price", "product_name" },
                values: new object[] { 1, "carrot cake any description", "carrot-cake-1200x800", 80, "carrot cake" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "description", "ImageFileName", "price", "product_name" },
                values: new object[] { 2, "cupcake any description", "cupcake.jpg", 55, "cupcake" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "description", "ImageFileName", "price", "product_name" },
                values: new object[] { 3, "choclate cake any description", "choclate cake.jpg", 60, "choclate cake" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "description", "ImageFileName", "price", "product_name" },
                values: new object[] { 4, "Lemon-cake any description", "Lemon-cake-recipe-500x500.jpg", 40, "Lemon-cake" }); 

            migrationBuilder.InsertData(
             table: "products",
             columns: new[] { "id", "description", "ImageFileName", "price", "product_name" },
             values: new object[] { 5, "Brownies cake", "Brownies_0-SQ.jpg", 50, "Brownies cake" });

            migrationBuilder.InsertData(
             table: "products",
             columns: new[] { "id", "description", "ImageFileName", "price", "product_name" },
             values: new object[] { 6, "Classic Roll", "Classic Roll_314x256.jpg", 50, "Classic Roll" });

            migrationBuilder.InsertData(
             table: "products",
             columns: new[] { "id", "description", "ImageFileName", "price", "product_name" },
             values: new object[] { 7, "Gluten-Free-Lemon-Tart", "Gluten-Free-Lemon-Tart-Recipe-17.jpg", 50, "Gluten-Free-Lemon-Tart" });

            migrationBuilder.InsertData(
             table: "products",
             columns: new[] { "id", "description", "ImageFileName", "price", "product_name" },
             values: new object[] { 8, "gluten-free-new-york-cheesecake", "gluten-free-new-york-cheesecake-1450985-hero-01-dc54f9daf38044238b495c7cefc191fa", 50, "gluten-free-new-york-cheesecake" });

            migrationBuilder.InsertData(
               table: "products",
               columns: new[] { "id", "description", "ImageFileName", "price", "product_name" },
               values: new object[] { 9, "chocolate-lava-cake", "chocolate-lava-cake-recipe-2.jpg", 60, "chocolate-lava-cake-" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
