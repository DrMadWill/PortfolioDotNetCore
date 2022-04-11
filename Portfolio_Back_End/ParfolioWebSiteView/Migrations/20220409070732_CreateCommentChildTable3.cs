using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class CreateCommentChildTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commets_Commets_ParentId",
                table: "Commets");

            migrationBuilder.DropIndex(
                name: "IX_Commets_ParentId",
                table: "Commets");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Commets");

            migrationBuilder.CreateTable(
                name: "CommentChildren",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "ntext", nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    BlogDetailsId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsBlocked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentChildren", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentChildren_BlogDetails_BlogDetailsId",
                        column: x => x.BlogDetailsId,
                        principalTable: "BlogDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentChildren_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentChildren_BlogDetailsId",
                table: "CommentChildren",
                column: "BlogDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentChildren_UserId",
                table: "CommentChildren",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentChildren");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Commets",
                type: "int",
                nullable: true);

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
    }
}
