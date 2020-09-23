using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AlteracaoColunaTransferencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "DispositivoId",
                table: "Transferencia",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DispositivoId",
                table: "Transferencia",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));
        }
    }
}
