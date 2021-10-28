using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionWebApi.Models.Migrations
{
    public partial class prueba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartamentId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartamentId",
                table: "Employees");
        }
    }
}
