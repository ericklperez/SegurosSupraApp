using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupraSeguros.Services.Accidents.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Siniestro",
                columns: table => new
                {
                    SiniestroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolizaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FechaSiniestro = table.Column<DateTime>(type: "date", nullable: true),
                    DescripcionSiniestro = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MontoDanios = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EstadoSiniestro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniestro", x => x.SiniestroId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Siniestro");
        }
    }
}
