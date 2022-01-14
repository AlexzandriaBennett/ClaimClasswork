using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppDemo.Data.Migrations
{
    public partial class AddedHero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hero",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hero",
                table: "movies");
        }
    }
}
