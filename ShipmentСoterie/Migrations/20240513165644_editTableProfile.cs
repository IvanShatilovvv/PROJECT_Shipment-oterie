using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShipmentСoterie.Migrations
{
    /// <inheritdoc />
    public partial class editTableProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "adres",
                table: "profile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adres",
                table: "profile");
        }
    }
}
