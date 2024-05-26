using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityWay.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrderForStopAndPoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Stops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Stops");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Routes");
        }
    }
}
