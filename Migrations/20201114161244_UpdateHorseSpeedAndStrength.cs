using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class UpdateHorseSpeedAndStrength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { 5, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { null, null });
        }
    }
}
