using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityWay.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDirectionsToStopAndRoutePoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Direction",
                table: "Stops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Direction",
                table: "RoutePoints",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direction",
                table: "Stops");

            migrationBuilder.DropColumn(
                name: "Direction",
                table: "RoutePoints");
        }
    }
}
