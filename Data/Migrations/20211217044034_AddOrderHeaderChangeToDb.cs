using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtSpace_Project.Data.Migrations
{
    public partial class AddOrderHeaderChangeToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShippingName",
                table: "OrderHeader");

            migrationBuilder.DropColumn(
                name: "ShippingTime",
                table: "OrderHeader");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryName",
                table: "OrderHeader",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryTime",
                table: "OrderHeader",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryName",
                table: "OrderHeader");

            migrationBuilder.DropColumn(
                name: "DeliveryTime",
                table: "OrderHeader");

            migrationBuilder.AddColumn<string>(
                name: "ShippingName",
                table: "OrderHeader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShippingTime",
                table: "OrderHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
