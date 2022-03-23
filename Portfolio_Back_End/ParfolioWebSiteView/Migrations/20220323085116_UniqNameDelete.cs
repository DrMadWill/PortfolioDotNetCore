using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class UniqNameDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SkillCodes_Name",
                table: "SkillCodes");

            migrationBuilder.DropIndex(
                name: "IX_Services_Name",
                table: "Services");

            migrationBuilder.AlterColumn<string>(
                name: "HomeSlogan",
                table: "Homes",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HomeSlogan",
                table: "Homes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 350);

            migrationBuilder.CreateIndex(
                name: "IX_SkillCodes_Name",
                table: "SkillCodes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_Name",
                table: "Services",
                column: "Name",
                unique: true);
        }
    }
}
