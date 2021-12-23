using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtSpace_Project.Data.Migrations
{
    public partial class AddSearchByArtistToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchByArtists",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchByArtists", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchByArtists");
        }
    }
}
