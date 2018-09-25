using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendamentoConsultas.Migrations
{
    public partial class medico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Convenio",
                table: "Medicos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Convenio",
                table: "Medicos",
                nullable: true);
        }
    }
}
