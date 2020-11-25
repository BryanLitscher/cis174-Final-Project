using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CS174FINALPROJECTLITSCHER.Migrations
{
    public partial class cartcust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartCustomer",
                columns: table => new
                {
                    CartCustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartCustomer", x => x.CartCustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartCustomerId = table.Column<int>(type: "int", nullable: false),
                    CartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Cart_CartCustomer_CartCustomerId",
                        column: x => x.CartCustomerId,
                        principalTable: "CartCustomer",
                        principalColumn: "CartCustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    CartItemDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CartItemQuantity = table.Column<int>(type: "int", nullable: false),
                    CartItemUnitPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CartCustomer",
                columns: new[] { "CartCustomerId", "CartEmail", "CartName" },
                values: new object[] { 1, "bclitscher@dmacc.edu", "Bryan Litscher" });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CartCustomerId",
                table: "Cart",
                column: "CartCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "CartCustomer");
        }
    }
}
