using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class PopulateKnightsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Knights",
                columns: new[] { "Id", "Castle", "Land", "Name" },
                values: new object[,]
                {
                    { 1, "Rainhaven", "Reach", "Ser Hugar Roxton" },
                    { 2, "Rainhaven", "Reach", "Ser Dareon Flowers" },
                    { 3, "Casterly Rock", "Westerlands", "Ser Jaime Lannister" },
                    { 4, "Rainwood", "Stormlands", "Ser Davos Seaworth" },
                    { 5, "Red Keep", "Crownlands", "Ser Barristan Selmy" },
                    { 6, "Riverrun", "Riverlands", "Ser Brynden Tully" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Knights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Knights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Knights",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Knights",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Knights",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Knights",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
