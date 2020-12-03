using Microsoft.EntityFrameworkCore.Migrations;

namespace CS174FINALPROJECTLITSCHER.Migrations
{
    public partial class cartitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CartItemName",
                table: "CartItem",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartItemName",
                table: "CartItem");
        }
    }
}
