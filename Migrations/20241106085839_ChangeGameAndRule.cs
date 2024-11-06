using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JRMTest.Migrations
{
    /// <inheritdoc />
    public partial class ChangeGameAndRule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rule_Games_GameId",
                table: "Rule");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rule_Games_GameId",
                table: "Rule");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Rule",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Rule_Games_GameId",
                table: "Rule",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");
        }
    }
}
