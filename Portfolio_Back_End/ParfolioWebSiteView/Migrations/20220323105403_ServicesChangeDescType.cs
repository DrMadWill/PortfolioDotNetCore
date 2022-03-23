using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class ServicesChangeDescType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descriptoion",
                table: "Services",
                maxLength: 700,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descriptoion",
                table: "Services",
                type: "ntext",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 700);
        }
    }
}
