using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Compras.Catalogo.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CustoCompra = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    MargemLucro = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
