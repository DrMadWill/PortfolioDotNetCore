using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class CreateConstraintKeyTableCommentParentToIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Commets_ParentId",
                table: "Commets",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commets_Commets_ParentId",
                table: "Commets",
                column: "ParentId",
                principalTable: "Commets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commets_Commets_ParentId",
                table: "Commets");

            migrationBuilder.DropIndex(
                name: "IX_Commets_ParentId",
                table: "Commets");
        }
    }
}
