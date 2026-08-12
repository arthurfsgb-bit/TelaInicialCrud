using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelaInicialCrud.Migrations
{
    /// <inheritdoc />
    public partial class CriandoNovaTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    IdProjeto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProjeto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    DataInicio = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataFinal = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    QuantPessoas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.IdProjeto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projetos");
        }
    }
}
