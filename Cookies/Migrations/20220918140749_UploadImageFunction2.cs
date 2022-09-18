using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cookies.Migrations
{
    public partial class UploadImageFunction2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "CookiePhoto",
                table: "AdminCookies",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CookiePhoto",
                table: "AdminCookies");
        }
    }
}
