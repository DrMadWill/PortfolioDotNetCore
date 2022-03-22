using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class ChangeInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Percent",
                table: "SkillCodes",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Percent",
                table: "SkillCodes",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }
    }
}
