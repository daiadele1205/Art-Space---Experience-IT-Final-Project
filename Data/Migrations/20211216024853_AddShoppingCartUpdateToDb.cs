using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtSpace_Project.Data.Migrations
{
    public partial class AddShoppingCartUpdateToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ShoppingCart",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ShoppingCart");
        }
    }
}
