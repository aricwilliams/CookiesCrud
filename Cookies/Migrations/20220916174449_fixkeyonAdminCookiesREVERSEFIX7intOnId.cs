using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cookies.Migrations
{
    public partial class fixkeyonAdminCookiesREVERSEFIX7intOnId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "AdminCookies",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                   .Annotation("SqlServer:Identity", "1, 1"),
                   Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Recipe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_AdminCookies", x => x.Id);
               });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminCookies");
        }
    }
}
