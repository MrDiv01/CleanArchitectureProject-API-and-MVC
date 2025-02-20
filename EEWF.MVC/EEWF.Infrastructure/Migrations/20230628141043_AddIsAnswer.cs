using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEWF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsAnswer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAnswer",
                table: "Appeals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Appeals",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAnswer",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAnswer",
                table: "Appeals");
        }
    }
}
