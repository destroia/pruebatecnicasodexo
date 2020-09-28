using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Facturas_FacturaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_FacturaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "Productos");

            migrationBuilder.AddColumn<Guid>(
                name: "IdCliente",
                table: "Facturas",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Facturas");

            migrationBuilder.AddColumn<Guid>(
                name: "FacturaId",
                table: "Productos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_FacturaId",
                table: "Productos",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Facturas_FacturaId",
                table: "Productos",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
