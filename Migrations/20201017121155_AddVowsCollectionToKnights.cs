using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class AddVowsCollectionToKnights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KnightId",
                table: "Vows",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vows_KnightId",
                table: "Vows",
                column: "KnightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vows_Knights_KnightId",
                table: "Vows",
                column: "KnightId",
                principalTable: "Knights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vows_Knights_KnightId",
                table: "Vows");

            migrationBuilder.DropIndex(
                name: "IX_Vows_KnightId",
                table: "Vows");

            migrationBuilder.DropColumn(
                name: "KnightId",
                table: "Vows");
        }
    }
}
