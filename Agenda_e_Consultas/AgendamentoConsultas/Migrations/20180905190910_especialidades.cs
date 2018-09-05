using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendamentoConsultas.Migrations
{
    public partial class especialidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Especialidade_EspecialidadeId",
                table: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especialidade",
                table: "Especialidade");

            migrationBuilder.RenameTable(
                name: "Especialidade",
                newName: "Especialidades");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadeId",
                table: "Medicos",
                column: "EspecialidadeId",
                principalTable: "Especialidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadeId",
                table: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades");

            migrationBuilder.RenameTable(
                name: "Especialidades",
                newName: "Especialidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidade",
                table: "Especialidade",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidade_EspecialidadeId",
                table: "Medicos",
                column: "EspecialidadeId",
                principalTable: "Especialidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
