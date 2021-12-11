using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtSpace_Project.Data.Migrations
{
    public partial class AddArtworkPortfolioToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtworkPortfolio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    MediumId = table.Column<int>(nullable: false),
                    ArtworkTypeId = table.Column<int>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkPortfolio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtworkPortfolio_ArtworkType_ArtworkTypeId",
                        column: x => x.ArtworkTypeId,
                        principalTable: "ArtworkType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ArtworkPortfolio_Medium_MediumId",
                        column: x => x.MediumId,
                        principalTable: "Medium",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkPortfolio_ArtworkTypeId",
                table: "ArtworkPortfolio",
                column: "ArtworkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkPortfolio_MediumId",
                table: "ArtworkPortfolio",
                column: "MediumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtworkPortfolio");
        }
    }
}
