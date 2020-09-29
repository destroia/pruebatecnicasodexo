using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Facturas");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Facturacion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "IdFactura",
                table: "Facturacion",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdProducto",
                table: "Facturacion",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Facturacion");

            migrationBuilder.DropColumn(
                name: "IdFactura",
                table: "Facturacion");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Facturacion");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductoId",
                table: "Facturas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
