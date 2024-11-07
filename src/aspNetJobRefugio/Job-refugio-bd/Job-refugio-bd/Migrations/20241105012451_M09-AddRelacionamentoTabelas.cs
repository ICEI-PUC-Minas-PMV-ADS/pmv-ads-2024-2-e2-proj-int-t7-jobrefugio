using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_refugio_bd.Migrations
{
    /// <inheritdoc />
    public partial class M09AddRelacionamentoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Inscrito_CandidatoId",
                table: "Inscrito");

            migrationBuilder.CreateIndex(
                name: "IX_Inscrito_CandidatoId_VagaId",
                table: "Inscrito",
                columns: new[] { "CandidatoId", "VagaId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Inscrito_CandidatoId_VagaId",
                table: "Inscrito");

            migrationBuilder.CreateIndex(
                name: "IX_Inscrito_CandidatoId",
                table: "Inscrito",
                column: "CandidatoId");
        }
    }
}
