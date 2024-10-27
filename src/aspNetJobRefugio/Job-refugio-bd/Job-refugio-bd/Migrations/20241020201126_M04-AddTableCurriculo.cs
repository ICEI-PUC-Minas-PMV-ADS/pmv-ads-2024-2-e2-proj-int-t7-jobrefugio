using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_refugio_bd.Migrations
{
    /// <inheritdoc />
    public partial class M04AddTableCurriculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curriculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormAcad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumoQualific = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincRealiza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpProf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjProf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CursosComplIdioma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandidatoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curriculo_Candidato_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidato",
                        principalColumn: "IdCandidato",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curriculo_CandidatoId",
                table: "Curriculo",
                column: "CandidatoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curriculo");
        }
    }
}
