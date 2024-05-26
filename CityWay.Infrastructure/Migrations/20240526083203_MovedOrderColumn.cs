using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityWay.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MovedOrderColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Routes");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "RoutePoints",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "RoutePoints");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
