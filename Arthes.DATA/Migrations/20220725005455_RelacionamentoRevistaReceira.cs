using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arthes.DATA.Migrations
{
    public partial class RelacionamentoRevistaReceira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RECEITAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dificuldade = table.Column<int>(type: "int", nullable: false),
                    Altura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RevistaId = table.Column<int>(type: "int", nullable: false),
                    _ModelRevistaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECEITAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RECEITAS_REVISTAS__ModelRevistaId",
                        column: x => x._ModelRevistaId,
                        principalTable: "REVISTAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RECEITAS__ModelRevistaId",
                table: "RECEITAS",
                column: "_ModelRevistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RECEITAS");
        }
    }
}
