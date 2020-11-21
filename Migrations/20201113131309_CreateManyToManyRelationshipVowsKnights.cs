using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class CreateManyToManyRelationshipVowsKnights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "KnightsVows",
                columns: table => new
                {
                    KnightID = table.Column<int>(nullable: false),
                    VowID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnightsVows", x => new { x.KnightID, x.VowID });
                    table.ForeignKey(
                        name: "FK_KnightsVows_Knights_KnightID",
                        column: x => x.KnightID,
                        principalTable: "Knights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnightsVows_Vows_VowID",
                        column: x => x.VowID,
                        principalTable: "Vows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KnightsVows_VowID",
                table: "KnightsVows",
                column: "VowID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnightsVows");

            migrationBuilder.AddColumn<int>(
                name: "KnightId",
                table: "Vows",
                type: "int",
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
    }
}
