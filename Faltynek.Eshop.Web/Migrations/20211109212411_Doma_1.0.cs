using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Faltynek.Eshop.Web.Migrations
{
    public partial class Doma_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

           //migrationBuilder.CreateTable(
           //     name: "CarouselItem",
           //     columns: table => new
           //     {
           //         ID = table.Column<int>(type: "int", nullable: false)
           //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
           //         ImageSource = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
           //             .Annotation("MySql:CharSet", "utf8mb4"),
           //         ImageAlt = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
           //             .Annotation("MySql:CharSet", "utf8mb4")
           //     },
           //     constraints: table =>
           //     {
           //         table.PrimaryKey("PK_CarouselItem", x => x.ID);
           //     })
           //     .Annotation("MySql:CharSet", "utf8mb4");

           // migrationBuilder.CreateTable(
           //     name: "Product",
           //     columns: table => new
           //     {
           //         ID = table.Column<int>(type: "int", nullable: false)
           //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
           //         ImageSource = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
           //             .Annotation("MySql:CharSet", "utf8mb4"),
           //         ImageAlt = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
           //             .Annotation("MySql:CharSet", "utf8mb4"),
           //         Price = table.Column<double>(type: "double", nullable: false),
           //         Info = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: false)
           //             .Annotation("MySql:CharSet", "utf8mb4")
           //     },
           //     constraints: table =>
           //     {
           //         table.PrimaryKey("PK_Product", x => x.ID);
           //     })
           //     .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarouselItem");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
