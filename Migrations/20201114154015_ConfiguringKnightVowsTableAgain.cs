using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class ConfiguringKnightVowsTableAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KnightsVows",
                columns: new[] { "KnightId", "VowId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "KnightsVows",
                columns: new[] { "KnightId", "VowId" },
                values: new object[] { 1, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 1, 4 });
        }
    }
}
