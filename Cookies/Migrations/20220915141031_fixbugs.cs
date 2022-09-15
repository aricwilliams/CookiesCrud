using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cookies.Migrations
{
    public partial class fixbugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CookieRecipies",
                table: "CookieRecipies");

            migrationBuilder.RenameTable(
                name: "CookieRecipies",
                newName: "CookieRecipes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CookieRecipes",
                table: "CookieRecipes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CookieRecipes",
                table: "CookieRecipes");

            migrationBuilder.RenameTable(
                name: "CookieRecipes",
                newName: "CookieRecipies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CookieRecipies",
                table: "CookieRecipies",
                column: "Id");
        }
    }
}
