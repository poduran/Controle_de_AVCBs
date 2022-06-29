using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeAvcbs.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ORIGEM",
                columns: table => new
                {
                    Origens = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORIGEM", x => x.Origens);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORIGEM");
        }
    }
}
