using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class PopulateHorsesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Horses",
                columns: new[] { "Id", "Color", "KnightId", "Name" },
                values: new object[,]
                {
                    { 1, "Brown", 1, "Rex" },
                    { 2, "White", 2, "Moondancer" },
                    { 3, "Grey", 6, "Trout" },
                    { 4, "Black", 5, "Ash" },
                    { 5, "Dark brown", 4, "Mel" },
                    { 6, "Chesnut", 3, "Honour" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
