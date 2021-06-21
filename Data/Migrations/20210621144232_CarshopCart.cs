using Microsoft.EntityFrameworkCore.Migrations;

namespace Carshop.Data.Migrations
{
    public partial class CarshopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarshopCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    carId = table.Column<int>(type: "INTEGER", nullable: true),
                    price = table.Column<int>(type: "INTEGER", nullable: false),
                    CarshopCartId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarshopCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarshopCartItem_Car_carId",
                        column: x => x.carId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarshopCartItem_carId",
                table: "CarshopCartItem",
                column: "carId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarshopCartItem");
        }
    }
}
