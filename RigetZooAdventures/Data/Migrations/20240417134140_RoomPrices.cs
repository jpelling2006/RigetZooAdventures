using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RigetZooAdventures.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoomPrices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PricePerNight",
                table: "RoomTypes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerNight",
                table: "RoomTypes");
        }
    }
}
