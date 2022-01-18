using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealOfficialLab3.Data.Migrations
{
    public partial class AddedStudentandCourseRelationshio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentAndCourseRelationship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentNumber = table.Column<int>(type: "int", nullable: false),
                    CourseNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAndCourseRelationship", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentAndCourseRelationship");
        }
    }
}
