using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_refugio_bd.Migrations
{
    /// <inheritdoc />
    public partial class M08AddDateTimeVagas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DataPublicacao",
                table: "Vaga",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPublicacao",
                table: "Vaga");
        }
    }
}
