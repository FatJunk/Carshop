using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Carshop.Data.Migrations
{
    public partial class Car0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryName = table.Column<string>(type: "TEXT", nullable: true),
                    Desc = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orderz",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    surrName = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    orderTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderz", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Pic = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<ushort>(type: "INTEGER", nullable: false),
                    isFav = table.Column<bool>(type: "INTEGER", nullable: false),
                    categoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car_Category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    orderId = table.Column<int>(type: "INTEGER", nullable: false),
                    carId = table.Column<int>(type: "INTEGER", nullable: false),
                    price = table.Column<uint>(type: "INTEGER", nullable: false),
                    Orderzid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Car_carId",
                        column: x => x.carId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Orderz_Orderzid",
                        column: x => x.Orderzid,
                        principalTable: "Orderz",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_categoryId",
                table: "Car",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CarshopCartItem_carId",
                table: "CarshopCartItem",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_carId",
                table: "OrderDetail",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_Orderzid",
                table: "OrderDetail",
                column: "Orderzid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarshopCartItem");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Orderz");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
