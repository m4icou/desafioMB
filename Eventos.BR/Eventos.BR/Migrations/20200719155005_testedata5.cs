using Microsoft.EntityFrameworkCore.Migrations;

namespace Eventos.BR.Migrations
{
    public partial class testedata5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "preco",
                table: "Ingresso",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "preco",
                table: "Ingresso",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
