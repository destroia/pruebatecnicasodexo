using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate104 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iva",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "PrecioIva",
                table: "Productos");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioSinIva",
                table: "Productos",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioSinIva",
                table: "Productos");

            migrationBuilder.AddColumn<decimal>(
                name: "Iva",
                table: "Productos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Productos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioIva",
                table: "Productos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
