using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UpdateTrainee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttitudeScore",
                table: "Trainees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseScore",
                table: "Trainees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectScore",
                table: "Trainees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttitudeScore",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "CourseScore",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "ProjectScore",
                table: "Trainees");
        }
    }
}
