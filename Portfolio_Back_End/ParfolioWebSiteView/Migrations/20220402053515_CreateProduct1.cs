using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfolioWebSiteView.Migrations
{
    public partial class CreateProduct1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seal_Prodact_ProdactId",
                table: "Seal");

            migrationBuilder.DropForeignKey(
                name: "FK_Seal_AspNetUsers_UserId",
                table: "Seal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seal",
                table: "Seal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prodact",
                table: "Prodact");

            migrationBuilder.RenameTable(
                name: "Seal",
                newName: "Seals");

            migrationBuilder.RenameTable(
                name: "Prodact",
                newName: "Prodacts");

            migrationBuilder.RenameIndex(
                name: "IX_Seal_UserId",
                table: "Seals",
                newName: "IX_Seals_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Seal_ProdactId",
                table: "Seals",
                newName: "IX_Seals_ProdactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seals",
                table: "Seals",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prodacts",
                table: "Prodacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seals_Prodacts_ProdactId",
                table: "Seals",
                column: "ProdactId",
                principalTable: "Prodacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seals_AspNetUsers_UserId",
                table: "Seals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seals_Prodacts_ProdactId",
                table: "Seals");

            migrationBuilder.DropForeignKey(
                name: "FK_Seals_AspNetUsers_UserId",
                table: "Seals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seals",
                table: "Seals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prodacts",
                table: "Prodacts");

            migrationBuilder.RenameTable(
                name: "Seals",
                newName: "Seal");

            migrationBuilder.RenameTable(
                name: "Prodacts",
                newName: "Prodact");

            migrationBuilder.RenameIndex(
                name: "IX_Seals_UserId",
                table: "Seal",
                newName: "IX_Seal_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Seals_ProdactId",
                table: "Seal",
                newName: "IX_Seal_ProdactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seal",
                table: "Seal",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prodact",
                table: "Prodact",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seal_Prodact_ProdactId",
                table: "Seal",
                column: "ProdactId",
                principalTable: "Prodact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seal_AspNetUsers_UserId",
                table: "Seal",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
