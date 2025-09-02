using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelationsNaN.Migrations
{
    /// <inheritdoc />
    public partial class peuImporteLeNom1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Platforms",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Platforms",
                table: "Game");
        }
    }
}
