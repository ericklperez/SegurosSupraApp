using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupraSeguros.Services.Agents.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agente",
                columns: table => new
                {
                    AgenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodigoAgente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agente", x => x.AgenteId);
                });

            migrationBuilder.CreateTable(
                name: "PolizaAgente",
                columns: table => new
                {
                    PolizaAgenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolizaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FechaAsignacion = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolizaAgente", x => x.PolizaAgenteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agente");

            migrationBuilder.DropTable(
                name: "PolizaAgente");
        }
    }
}
