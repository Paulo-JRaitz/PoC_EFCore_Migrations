using Microsoft.EntityFrameworkCore.Migrations;

namespace EFPoc.Migrations
{
    public partial class HeroisBatalhas_Identidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeroiBatalhas",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    BatalhaId = table.Column<int>(type: "int", nullable: false),
                    HeroiBatalhaBatalhaId = table.Column<int>(type: "int", nullable: true),
                    HeroiBatalhaHeroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroiBatalhas", x => new { x.BatalhaId, x.HeroId });
                    table.ForeignKey(
                        name: "FK_HeroiBatalhas_Batalhas_BatalhaId",
                        column: x => x.BatalhaId,
                        principalTable: "Batalhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroiBatalhas_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroiBatalhas_HeroiBatalhas_HeroiBatalhaBatalhaId_HeroiBatalhaHeroId",
                        columns: x => new { x.HeroiBatalhaBatalhaId, x.HeroiBatalhaHeroId },
                        principalTable: "HeroiBatalhas",
                        principalColumns: new[] { "BatalhaId", "HeroId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdentidadeSecretas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeReal = table.Column<int>(type: "int", nullable: false),
                    HeroiId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentidadeSecretas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentidadeSecretas_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroiBatalhas_HeroiBatalhaBatalhaId_HeroiBatalhaHeroId",
                table: "HeroiBatalhas",
                columns: new[] { "HeroiBatalhaBatalhaId", "HeroiBatalhaHeroId" });

            migrationBuilder.CreateIndex(
                name: "IX_HeroiBatalhas_HeroId",
                table: "HeroiBatalhas",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentidadeSecretas_HeroId",
                table: "IdentidadeSecretas",
                column: "HeroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroiBatalhas");

            migrationBuilder.DropTable(
                name: "IdentidadeSecretas");
        }
    }
}
