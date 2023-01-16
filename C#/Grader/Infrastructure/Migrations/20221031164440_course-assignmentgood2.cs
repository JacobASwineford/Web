using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class courseassignmentgood2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourseAssignments_Course_CourseId",
                table: "StudentCourseAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourseAssignments_Student_StudentId",
                table: "StudentCourseAssignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourseAssignments",
                table: "StudentCourseAssignments");

            migrationBuilder.RenameTable(
                name: "StudentCourseAssignments",
                newName: "StudentCourseAssignment");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourseAssignments_StudentId",
                table: "StudentCourseAssignment",
                newName: "IX_StudentCourseAssignment_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourseAssignments_CourseId",
                table: "StudentCourseAssignment",
                newName: "IX_StudentCourseAssignment_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourseAssignment",
                table: "StudentCourseAssignment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourseAssignment_Course_CourseId",
                table: "StudentCourseAssignment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourseAssignment_Student_StudentId",
                table: "StudentCourseAssignment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourseAssignment_Course_CourseId",
                table: "StudentCourseAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourseAssignment_Student_StudentId",
                table: "StudentCourseAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourseAssignment",
                table: "StudentCourseAssignment");

            migrationBuilder.RenameTable(
                name: "StudentCourseAssignment",
                newName: "StudentCourseAssignments");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourseAssignment_StudentId",
                table: "StudentCourseAssignments",
                newName: "IX_StudentCourseAssignments_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourseAssignment_CourseId",
                table: "StudentCourseAssignments",
                newName: "IX_StudentCourseAssignments_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourseAssignments",
                table: "StudentCourseAssignments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourseAssignments_Course_CourseId",
                table: "StudentCourseAssignments",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourseAssignments_Student_StudentId",
                table: "StudentCourseAssignments",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
