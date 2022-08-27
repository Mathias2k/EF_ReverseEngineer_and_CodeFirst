using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_ReverseEngineer_and_CodeFirst.Migrations
{
    public partial class ThridMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Bikes");
        }
    }
}
