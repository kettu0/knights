using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class CorrectDataInWeaponsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 8,
                column: "KnightId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 8,
                column: "KnightId",
                value: 1);
        }
    }
}
