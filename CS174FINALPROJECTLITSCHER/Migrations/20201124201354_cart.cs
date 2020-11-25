using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CS174FINALPROJECTLITSCHER.Migrations
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartId", "CartCustomerId", "CartDateTime" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "CartId",
                keyValue: 1);
        }
    }
}
