using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class PopulateWeaponsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "KnightId", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 1, "Big ass sword", "Great Sword" },
                    { 2, 1, "Lady Selma", "Dagger" },
                    { 3, 2, "Eleine", "Bastard sword" },
                    { 4, 2, "Stranger thing", "Small crossbow" },
                    { 5, 2, "Canary", "Shield" },
                    { 7, 3, "Brightroar", "Longsword" },
                    { 8, 1, "Lion", "Shield" },
                    { 9, 7, "Oathkeeper", "Longsword" },
                    { 10, 6, "Blackfish", "Bastard sword" },
                    { 11, 6, "Arrows of Trident", "Longbow" },
                    { 12, 6, "Fisherman dagger", "Dagger" },
                    { 13, 5, "LoyalToRoyal", "Longsword" },
                    { 14, 4, "Rogue", "Dagger" },
                    { 15, 4, "Mother mercy", "Small crossbow" },
                    { 16, 4, "Onion", "Short sword" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
