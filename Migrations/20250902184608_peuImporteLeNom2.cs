using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelationsNaN.Migrations
{
    /// <inheritdoc />
    public partial class peuImporteLeNom2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Platforms",
                table: "Game");

            migrationBuilder.CreateTable(
                name: "Plateforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plateforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GamePlateform",
                columns: table => new
                {
                    GamesId = table.Column<int>(type: "int", nullable: false),
                    PlateformsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlateform", x => new { x.GamesId, x.PlateformsId });
                    table.ForeignKey(
                        name: "FK_GamePlateform_Game_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlateform_Plateforms_PlateformsId",
                        column: x => x.PlateformsId,
                        principalTable: "Plateforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePurchase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PurchaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePurchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePurchase_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePurchase_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GamePlateform_PlateformsId",
                table: "GamePlateform",
                column: "PlateformsId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePurchase_GameId",
                table: "GamePurchase",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePurchase_PurchaseId",
                table: "GamePurchase",
                column: "PurchaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamePlateform");

            migrationBuilder.DropTable(
                name: "GamePurchase");

            migrationBuilder.DropTable(
                name: "Plateforms");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.AddColumn<string>(
                name: "Platforms",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
