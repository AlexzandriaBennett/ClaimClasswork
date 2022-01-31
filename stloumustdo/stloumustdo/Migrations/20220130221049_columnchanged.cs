using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace stloumustdo.Migrations
{
    public partial class columnchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LocationArea",
                table: "StatewideOutdoors",
                newName: "DistanceFromSTL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DistanceFromSTL",
                table: "StatewideOutdoors",
                newName: "LocationArea");
        }
    }
}
