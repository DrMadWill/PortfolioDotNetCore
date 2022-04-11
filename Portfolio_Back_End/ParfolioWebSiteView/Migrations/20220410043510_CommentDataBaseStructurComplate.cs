using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class CommentDataBaseStructurComplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentChildren");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Commets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Commets");

            migrationBuilder.CreateTable(
                name: "CommentChildren",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogDetailsId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "ntext", nullable: false),
                    CommetId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                        name: "FK_CommentChildren_Commets_CommetId",
                        column: x => x.CommetId,
                        principalTable: "Commets",
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
                name: "IX_CommentChildren_CommetId",
                table: "CommentChildren",
                column: "CommetId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentChildren_UserId",
                table: "CommentChildren",
                column: "UserId");
        }
    }
}
