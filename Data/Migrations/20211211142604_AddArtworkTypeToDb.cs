using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtSpace_Project.Data.Migrations
{
    public partial class AddArtworkTypeToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtworkType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    MediumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtworkType_Medium_MediumId",
                        column: x => x.MediumId,
                        principalTable: "Medium",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkType_MediumId",
                table: "ArtworkType",
                column: "MediumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtworkType");
        }
    }
}
