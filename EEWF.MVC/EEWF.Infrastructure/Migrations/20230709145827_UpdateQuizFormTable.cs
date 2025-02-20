using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEWF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuizFormTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CorectAnswerCount",
                table: "QuizForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FalseAnswerCount",
                table: "QuizForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "QuizForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "QuizForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_QuizForms_LevelId",
                table: "QuizForms",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizForms_Levels_LevelId",
                table: "QuizForms",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizForms_Levels_LevelId",
                table: "QuizForms");

            migrationBuilder.DropIndex(
                name: "IX_QuizForms_LevelId",
                table: "QuizForms");

            migrationBuilder.DropColumn(
                name: "CorectAnswerCount",
                table: "QuizForms");

            migrationBuilder.DropColumn(
                name: "FalseAnswerCount",
                table: "QuizForms");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "QuizForms");

            migrationBuilder.DropColumn(
                name: "Point",
                table: "QuizForms");
        }
    }
}
