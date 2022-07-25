using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class TableUserAddFildIsEmailAndPhoneNumberShow1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsEmailAndPhoneNumberShow",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsEmailAndPhoneNumberShow",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(bool));
        }
    }
}
