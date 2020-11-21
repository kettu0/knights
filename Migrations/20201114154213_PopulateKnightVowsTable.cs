using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class PopulateKnightVowsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KnightsVows",
                columns: new[] { "KnightId", "VowId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 7, 3 },
                    { 6, 2 },
                    { 6, 1 },
                    { 5, 7 },
                    { 5, 6 },
                    { 5, 5 },
                    { 5, 4 },
                    { 5, 3 },
                    { 5, 2 },
                    { 7, 4 },
                    { 5, 1 },
                    { 4, 3 },
                    { 4, 6 },
                    { 3, 3 },
                    { 3, 1 },
                    { 3, 7 },
                    { 3, 5 },
                    { 3, 6 },
                    { 2, 7 },
                    { 2, 1 },
                    { 4, 2 },
                    { 7, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "KnightsVows",
                keyColumns: new[] { "KnightId", "VowId" },
                keyValues: new object[] { 7, 7 });
        }
    }
}
