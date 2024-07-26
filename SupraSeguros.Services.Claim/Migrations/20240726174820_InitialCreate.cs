using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupraSeguros.Services.Claim.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reclamacion",
                columns: table => new
                {
                    ReclamacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolizaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FechaReclamacion = table.Column<DateTime>(type: "date", nullable: true),
                    MontoReclamado = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MontoAprobado = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamacion", x => x.ReclamacionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reclamacion");
        }
    }
}
