using Microsoft.EntityFrameworkCore.Migrations;

namespace Recibos.Model.Migrations
{
    public partial class RecibosFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    ReciboId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TomadorNome = table.Column<string>(nullable: true),
                    TomadorCpf = table.Column<string>(nullable: true),
                    ServicoDescricao = table.Column<string>(nullable: true),
                    ServicoValor = table.Column<string>(nullable: true),
                    ServicoData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.ReciboId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recibos");
        }
    }
}
