using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RigetZooAdventures.Data.Migrations
{
    /// <inheritdoc />
    public partial class TicketsWithUserAssignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Tickets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Tickets");
        }
    }
}
