using Microsoft.EntityFrameworkCore.Migrations;

namespace SodaStore.Data.Migrations
{
    public partial class SodaProductImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "SodaProducts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "SodaProducts");
        }
    }
}
