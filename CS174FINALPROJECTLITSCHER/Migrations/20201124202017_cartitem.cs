using Microsoft.EntityFrameworkCore.Migrations;

namespace CS174FINALPROJECTLITSCHER.Migrations
{
    public partial class cartitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CartItem",
                columns: new[] { "CartItemId", "CartId", "CartItemDescription", "CartItemQuantity", "CartItemUnitPrice" },
                values: new object[] { 1, 1, "this is what you bought", 1, 56.32 });

            migrationBuilder.InsertData(
                table: "CartItem",
                columns: new[] { "CartItemId", "CartId", "CartItemDescription", "CartItemQuantity", "CartItemUnitPrice" },
                values: new object[] { 2, 1, "this is antoher thing that you bought", 1, 56.32 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CartItem",
                keyColumn: "CartItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartItem",
                keyColumn: "CartItemId",
                keyValue: 2);
        }
    }
}
