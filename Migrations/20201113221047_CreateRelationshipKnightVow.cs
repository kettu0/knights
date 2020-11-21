using Microsoft.EntityFrameworkCore.Migrations;

namespace Knights.Migrations
{
    public partial class CreateRelationshipKnightVow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KnightsVows_Knights_KnightID",
                table: "KnightsVows");

            migrationBuilder.DropForeignKey(
                name: "FK_KnightsVows_Vows_VowID",
                table: "KnightsVows");

            migrationBuilder.RenameColumn(
                name: "VowID",
                table: "KnightsVows",
                newName: "VowId");

            migrationBuilder.RenameColumn(
                name: "KnightID",
                table: "KnightsVows",
                newName: "KnightId");

            migrationBuilder.RenameIndex(
                name: "IX_KnightsVows_VowID",
                table: "KnightsVows",
                newName: "IX_KnightsVows_VowId");

            migrationBuilder.AddForeignKey(
                name: "FK_KnightsVows_Knights_KnightId",
                table: "KnightsVows",
                column: "KnightId",
                principalTable: "Knights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KnightsVows_Vows_VowId",
                table: "KnightsVows",
                column: "VowId",
                principalTable: "Vows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KnightsVows_Knights_KnightId",
                table: "KnightsVows");

            migrationBuilder.DropForeignKey(
                name: "FK_KnightsVows_Vows_VowId",
                table: "KnightsVows");

            migrationBuilder.RenameColumn(
                name: "VowId",
                table: "KnightsVows",
                newName: "VowID");

            migrationBuilder.RenameColumn(
                name: "KnightId",
                table: "KnightsVows",
                newName: "KnightID");

            migrationBuilder.RenameIndex(
                name: "IX_KnightsVows_VowId",
                table: "KnightsVows",
                newName: "IX_KnightsVows_VowID");

            migrationBuilder.AddForeignKey(
                name: "FK_KnightsVows_Knights_KnightID",
                table: "KnightsVows",
                column: "KnightID",
                principalTable: "Knights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KnightsVows_Vows_VowID",
                table: "KnightsVows",
                column: "VowID",
                principalTable: "Vows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
