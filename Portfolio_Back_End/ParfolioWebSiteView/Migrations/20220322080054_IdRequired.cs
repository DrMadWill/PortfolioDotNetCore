using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class IdRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillCodes_Abouts_AboutId",
                table: "SkillCodes");

            migrationBuilder.AlterColumn<string>(
                name: "AboutId",
                table: "SkillCodes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillCodes_Abouts_AboutId",
                table: "SkillCodes",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillCodes_Abouts_AboutId",
                table: "SkillCodes");

            migrationBuilder.AlterColumn<string>(
                name: "AboutId",
                table: "SkillCodes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_SkillCodes_Abouts_AboutId",
                table: "SkillCodes",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
