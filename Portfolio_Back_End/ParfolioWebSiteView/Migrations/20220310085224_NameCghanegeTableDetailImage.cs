using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class NameCghanegeTableDetailImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailImage_PortfolioDetails_PortfolioDetailId",
                table: "DetailImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailImage",
                table: "DetailImage");

            migrationBuilder.RenameTable(
                name: "DetailImage",
                newName: "DetailImages");

            migrationBuilder.RenameIndex(
                name: "IX_DetailImage_PortfolioDetailId",
                table: "DetailImages",
                newName: "IX_DetailImages_PortfolioDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailImages",
                table: "DetailImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailImages_PortfolioDetails_PortfolioDetailId",
                table: "DetailImages",
                column: "PortfolioDetailId",
                principalTable: "PortfolioDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailImages_PortfolioDetails_PortfolioDetailId",
                table: "DetailImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailImages",
                table: "DetailImages");

            migrationBuilder.RenameTable(
                name: "DetailImages",
                newName: "DetailImage");

            migrationBuilder.RenameIndex(
                name: "IX_DetailImages_PortfolioDetailId",
                table: "DetailImage",
                newName: "IX_DetailImage_PortfolioDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailImage",
                table: "DetailImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailImage_PortfolioDetails_PortfolioDetailId",
                table: "DetailImage",
                column: "PortfolioDetailId",
                principalTable: "PortfolioDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
