using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LivrariaUninassau.Migrations
{
    public partial class Bancodedados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emprestimo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Editora = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Idioma = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    NumeroDePaginas = table.Column<int>(type: "int", maxLength: 64, nullable: false),
                    ISBN = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    Quantidade = table.Column<int>(type: "int", maxLength: 64, nullable: false),
                    dataPublicação = table.Column<DateTime>(type: "datetime2", maxLength: 64, nullable: false),
                    dataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimo");
        }
    }
}
