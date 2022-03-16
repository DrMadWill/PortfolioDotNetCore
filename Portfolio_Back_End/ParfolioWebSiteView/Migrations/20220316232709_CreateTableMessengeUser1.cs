using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class CreateTableMessengeUser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessengeUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessengeUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessengeUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MessengeUsers_UserId",
                table: "MessengeUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessengeUsers");
        }
    }
}
