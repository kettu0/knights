using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class UpdateHorseSpeedAndStrengthAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { 14, 6 });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { 12, 8 });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { 7, 13 });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { 13, 7 });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { 3, 17 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Speed", "Strength" },
                values: new object[] { null, null });
        }
    }
}
