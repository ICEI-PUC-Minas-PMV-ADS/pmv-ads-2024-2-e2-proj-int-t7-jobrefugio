using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_refugio_bd.Migrations
{
    /// <inheritdoc />
    public partial class M01AddTableVagas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpregadorId = table.Column<int>(type: "int", nullable: false),
                    NomeCargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetodoContratacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VagaPCD = table.Column<bool>(type: "bit", nullable: false),
                    RegimeTrabalho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SobreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescVaga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequisitosQualificacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoAdicional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaga_Empregador_EmpregadorId",
                        column: x => x.EmpregadorId,
                        principalTable: "Empregador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_EmpregadorId",
                table: "Vaga",
                column: "EmpregadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaga");
        }
    }
}
