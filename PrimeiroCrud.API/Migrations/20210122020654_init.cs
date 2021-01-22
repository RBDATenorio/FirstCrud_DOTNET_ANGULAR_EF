using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimeiroCrud.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bandas",
                columns: table => new
                {
                    BandaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    CD1 = table.Column<string>(nullable: true),
                    CD2 = table.Column<string>(nullable: true),
                    CD3 = table.Column<string>(nullable: true),
                    CD4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandas", x => x.BandaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bandas");
        }
    }
}
