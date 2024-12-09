using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_refugio_bd.Migrations
{
    /// <inheritdoc />
    public partial class M11RemoveTableUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCandidato = table.Column<int>(type: "int", nullable: true),
                    IdEmpregador = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Candidato_IdCandidato",
                        column: x => x.IdCandidato,
                        principalTable: "Candidato",
                        principalColumn: "IdCandidato");
                    table.ForeignKey(
                        name: "FK_Usuario_Empregador_IdEmpregador",
                        column: x => x.IdEmpregador,
                        principalTable: "Empregador",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdCandidato",
                table: "Usuario",
                column: "IdCandidato",
                unique: true,
                filter: "[IdCandidato] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdEmpregador",
                table: "Usuario",
                column: "IdEmpregador",
                unique: true,
                filter: "[IdEmpregador] IS NOT NULL");
        }
    }
}
