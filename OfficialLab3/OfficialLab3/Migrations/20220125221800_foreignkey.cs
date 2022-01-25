using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficialLab3.Migrations
{
    public partial class foreignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Course_CourseId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Student_StudentId",
                table: "CourseStudent");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "CourseStudent",
                newName: "StudentsId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CourseStudent",
                newName: "CoursesId");


            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Course_CoursesId",
                table: "CourseStudent",
                column: "CoursesId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Student_StudentsId",
                table: "CourseStudent",
                column: "StudentsId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Course_CoursesId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Student_StudentsId",
                table: "CourseStudent");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "CourseStudent",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CourseStudent",
                newName: "CourseId");

 

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);


            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Course_CourseId",
                table: "CourseStudent",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Student_StudentId",
                table: "CourseStudent",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
