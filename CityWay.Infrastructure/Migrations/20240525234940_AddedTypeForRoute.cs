using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityWay.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedTypeForRoute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Routes");
        }
    }
}
