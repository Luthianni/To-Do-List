using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PraHoje.Migrations
{
    public partial class InicialToDoList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TarefasListas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DataDaFinalizacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarefasListas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TarefasListas");
        }
    }
}
