using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JRMTest.Migrations
{
    /// <inheritdoc />
    public partial class ChangeGameAndRuless : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rule_Games_GameId",
                table: "Rule");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Rule",
                newName: "gameId");

            migrationBuilder.RenameIndex(
                name: "IX_Rule_GameId",
                table: "Rule",
                newName: "IX_Rule_gameId");

            migrationBuilder.AlterColumn<int>(
                name: "gameId",
                table: "Rule",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Rule_Games_gameId",
                table: "Rule",
                column: "gameId",
                principalTable: "Games",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rule_Games_gameId",
                table: "Rule");

            migrationBuilder.RenameColumn(
                name: "gameId",
                table: "Rule",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Rule_gameId",
                table: "Rule",
                newName: "IX_Rule_GameId");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Rule",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rule_Games_GameId",
                table: "Rule",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
