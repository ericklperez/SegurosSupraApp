using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupraSeguros.Services.Policy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cobertura",
                columns: table => new
                {
                    CoberturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LimiteMaximo = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobertura", x => x.CoberturaId);
                });

            migrationBuilder.CreateTable(
                name: "Poliza",
                columns: table => new
                {
                    PolizaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroPoliza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipoSeguro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prima = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    Deducible = table.Column<decimal>(type: "decimal(6,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poliza", x => x.PolizaId);
                });

            migrationBuilder.CreateTable(
                name: "PolizaCobertura",
                columns: table => new
                {
                    PolizaCoberturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoberturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolizaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MontoCubierto = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolizaCobertura", x => x.PolizaCoberturaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cobertura");

            migrationBuilder.DropTable(
                name: "Poliza");

            migrationBuilder.DropTable(
                name: "PolizaCobertura");
        }
    }
}
