using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rommanel.Cliente.Infraestructure.Migrations
{
    public partial class Rommanel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CLIENTES",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CpfCnpj = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    Cep = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    TipoPessoa = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    InscricaoEstadual = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Numero = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    Estado = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CLIENTES", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CLIENTES");
        }
    }
}
