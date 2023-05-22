using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculadoraCientifica.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculos",
                columns: table => new
                {
                    CalcId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Operador = table.Column<double>(type: "float", nullable: false),
                    Resultado = table.Column<double>(type: "float", nullable: false),
                    Operacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculos", x => x.CalcId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculos");
        }
    }
}
