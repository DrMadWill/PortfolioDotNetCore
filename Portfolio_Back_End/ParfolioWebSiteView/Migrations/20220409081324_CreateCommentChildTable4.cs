using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class CreateCommentChildTable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommetId",
                table: "CommentChildren",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CommentChildren_CommetId",
                table: "CommentChildren",
                column: "CommetId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentChildren_Commets_CommetId",
                table: "CommentChildren",
                column: "CommetId",
                principalTable: "Commets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentChildren_Commets_CommetId",
                table: "CommentChildren");

            migrationBuilder.DropIndex(
                name: "IX_CommentChildren_CommetId",
                table: "CommentChildren");

            migrationBuilder.DropColumn(
                name: "CommetId",
                table: "CommentChildren");
        }
    }
}
