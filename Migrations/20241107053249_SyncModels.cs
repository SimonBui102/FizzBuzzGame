using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JRMTest.Migrations
{
    /// <inheritdoc />
    public partial class SyncModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rule_Games_gameId",
                table: "Rule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rule",
                table: "Rule");

            migrationBuilder.RenameTable(
                name: "Rule",
                newName: "Rules");

            migrationBuilder.RenameIndex(
                name: "IX_Rule_gameId",
                table: "Rules",
                newName: "IX_Rules_gameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rules",
                table: "Rules",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_Games_gameId",
                table: "Rules",
                column: "gameId",
                principalTable: "Games",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rules_Games_gameId",
                table: "Rules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rules",
                table: "Rules");

            migrationBuilder.RenameTable(
                name: "Rules",
                newName: "Rule");

            migrationBuilder.RenameIndex(
                name: "IX_Rules_gameId",
                table: "Rule",
                newName: "IX_Rule_gameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rule",
                table: "Rule",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rule_Games_gameId",
                table: "Rule",
                column: "gameId",
                principalTable: "Games",
                principalColumn: "Id");
        }
    }
}
