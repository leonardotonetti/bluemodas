using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueModasApi.Data.Migrations
{
    public partial class SequencePedidoCodigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PedidoCodigo",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR PedidoCodigo",
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PedidoCodigo",
                table: "Pedido",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR PedidoCodigo");
        }
    }
}
