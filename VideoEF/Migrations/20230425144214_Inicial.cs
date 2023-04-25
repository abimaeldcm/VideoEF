using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoEF.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) //REGISTRA TUDO QUE FOI FEITO NA MIGRATION APÓS REALIZAR O COMANDO
        {
            migrationBuilder.CreateTable(
                name: "Clientes",       //CRIA UMA TABELA COM O NOME "CLEINTES"
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false) //VAI CRIAR UMA COLONA DE NOME "ID" NO TIPO INT.
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)  //VAI CRIAR UMA COLONA DE NOME "NOME" NO TIPO NVARCHAR COM O MÁXIMO DE LINHAS POSSIVEIS.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) //REGISTRA O QUE ESTAVA NO DB ANTES DE REALIZAR A MIGRATION
        {
            migrationBuilder.DropTable(  //VAI DESFAZER O AS ALTERAÇÕES REALIZADAS ANTERIOMENTE NO CÓDIGO.
                name: "Clientes");
        }
    }
}
