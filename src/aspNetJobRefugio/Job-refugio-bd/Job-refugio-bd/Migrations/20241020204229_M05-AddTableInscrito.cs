using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_refugio_bd.Migrations
{
    /// <inheritdoc />
    public partial class M05AddTableInscrito : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inscrito",
                columns: table => new
                {
                    Idinscricao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInscricao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusInscricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CandidatoId = table.Column<int>(type: "int", nullable: false),
                    VagaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscrito", x => x.Idinscricao);
                    table.ForeignKey(
                        name: "FK_Inscrito_Candidato_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidato",
                        principalColumn: "IdCandidato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscrito_Vaga_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vaga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscrito_CandidatoId",
                table: "Inscrito",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscrito_VagaId",
                table: "Inscrito",
                column: "VagaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscrito");
        }
    }
}
