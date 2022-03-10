using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class ChangeTableAchievements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwardWon",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "TotalClents",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "WorksComplate",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "YearsExperoence",
                table: "Achievements");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Achievements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Achievements",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Achievements",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Achievements");

            migrationBuilder.AddColumn<int>(
                name: "AwardWon",
                table: "Achievements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalClents",
                table: "Achievements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorksComplate",
                table: "Achievements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsExperoence",
                table: "Achievements",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
