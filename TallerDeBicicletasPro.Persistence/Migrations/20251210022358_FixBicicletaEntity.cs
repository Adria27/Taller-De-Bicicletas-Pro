using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerDeBicicletasPro.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixBicicletaEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bicicletas_Clientes_ClienteId",
                table: "Bicicletas");

            migrationBuilder.DropColumn(
                name: "Año",
                table: "Bicicletas");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Bicicletas");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Bicicletas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Bicicletas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Bicicletas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Bicicletas_Clientes_ClienteId",
                table: "Bicicletas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bicicletas_Clientes_ClienteId",
                table: "Bicicletas");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Bicicletas");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Bicicletas");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Bicicletas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Año",
                table: "Bicicletas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Bicicletas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Bicicletas_Clientes_ClienteId",
                table: "Bicicletas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
