using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class initbetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_Course_CourseId",
                table: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Score_CourseId",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Score");

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "Assignment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_AssignmentId",
                table: "Assignment",
                column: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Course_AssignmentId",
                table: "Assignment",
                column: "AssignmentId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Course_AssignmentId",
                table: "Assignment");

            migrationBuilder.DropIndex(
                name: "IX_Assignment_AssignmentId",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "Assignment");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Score",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Score_CourseId",
                table: "Score",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Course_CourseId",
                table: "Score",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
