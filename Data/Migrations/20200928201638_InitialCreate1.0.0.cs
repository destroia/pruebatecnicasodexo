using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Clientes_ClienteId",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Factura_FacturaId",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factura",
                table: "Factura");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "Factura",
                newName: "Facturas");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_FacturaId",
                table: "Productos",
                newName: "IX_Productos_FacturaId");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_ClienteId",
                table: "Facturas",
                newName: "IX_Facturas_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "inpuestos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TipoImpuesto = table.Column<string>(nullable: true),
                    Porcentaje = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inpuestos", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_ClienteId",
                table: "Facturas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Facturas_FacturaId",
                table: "Productos",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_ClienteId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Facturas_FacturaId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "inpuestos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameTable(
                name: "Facturas",
                newName: "Factura");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_FacturaId",
                table: "Producto",
                newName: "IX_Producto_FacturaId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_ClienteId",
                table: "Factura",
                newName: "IX_Factura_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factura",
                table: "Factura",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Clientes_ClienteId",
                table: "Factura",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Factura_FacturaId",
                table: "Producto",
                column: "FacturaId",
                principalTable: "Factura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
