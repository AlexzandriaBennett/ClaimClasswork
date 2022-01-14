using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppDemo.Data.Migrations
{
    public partial class AddRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "movies");
        }
    }
}
