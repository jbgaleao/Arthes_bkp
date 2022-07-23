using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arthes.DATA.Migrations
{
    public partial class RetiradaCampoPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "REVISTAS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "REVISTAS",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
