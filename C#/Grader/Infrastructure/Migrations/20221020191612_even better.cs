using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class evenbetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Course_AssignmentId",
                table: "Assignment");

            migrationBuilder.RenameColumn(
                name: "AssignmentId",
                table: "Assignment",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_AssignmentId",
                table: "Assignment",
                newName: "IX_Assignment_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Course_CourseId",
                table: "Assignment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Course_CourseId",
                table: "Assignment");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Assignment",
                newName: "AssignmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_CourseId",
                table: "Assignment",
                newName: "IX_Assignment_AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Course_AssignmentId",
                table: "Assignment",
                column: "AssignmentId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
