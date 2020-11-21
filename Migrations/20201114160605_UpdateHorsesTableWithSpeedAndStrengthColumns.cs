using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class UpdateHorsesTableWithSpeedAndStrengthColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Knights_KnightId",
                table: "Weapons");

            migrationBuilder.AlterColumn<int>(
                name: "KnightId",
                table: "Weapons",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Horses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "Horses",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Knights_KnightId",
                table: "Weapons",
                column: "KnightId",
                principalTable: "Knights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Knights_KnightId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Horses");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "Horses");

            migrationBuilder.AlterColumn<int>(
                name: "KnightId",
                table: "Weapons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Knights_KnightId",
                table: "Weapons",
                column: "KnightId",
                principalTable: "Knights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
