using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AdicaoDispositivoDestino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transferencia_DispositivoId_Ativa",
                table: "Transferencia");

            migrationBuilder.DropColumn(
                name: "DispositivoId",
                table: "Transferencia");

            migrationBuilder.AddColumn<Guid>(
                name: "DispositivoDestinoId",
                table: "Transferencia",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DispositivoOrigemId",
                table: "Transferencia",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Transferencia_DispositivoOrigemId_Ativa",
                table: "Transferencia",
                columns: new[] { "DispositivoOrigemId", "Ativa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transferencia_DispositivoOrigemId_Ativa",
                table: "Transferencia");

            migrationBuilder.DropColumn(
                name: "DispositivoDestinoId",
                table: "Transferencia");

            migrationBuilder.DropColumn(
                name: "DispositivoOrigemId",
                table: "Transferencia");

            migrationBuilder.AddColumn<Guid>(
                name: "DispositivoId",
                table: "Transferencia",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Transferencia_DispositivoId_Ativa",
                table: "Transferencia",
                columns: new[] { "DispositivoId", "Ativa" });
        }
    }
}
