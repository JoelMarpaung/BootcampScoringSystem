using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UpdateTraineeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Trainees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_EmployeeId",
                table: "Trainees",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Employees_EmployeeId",
                table: "Trainees",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Employees_EmployeeId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_EmployeeId",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Trainees");
        }
    }
}
