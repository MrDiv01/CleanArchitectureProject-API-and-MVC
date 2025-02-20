using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEWF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUrlToLevelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Levels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Levels");
        }
    }
}
