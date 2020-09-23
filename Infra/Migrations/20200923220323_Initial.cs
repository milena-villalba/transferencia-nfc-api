using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transferencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    DispositivoId = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Ativa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferencia", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transferencia_DispositivoId_Ativa",
                table: "Transferencia",
                columns: new[] { "DispositivoId", "Ativa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transferencia");
        }
    }
}
