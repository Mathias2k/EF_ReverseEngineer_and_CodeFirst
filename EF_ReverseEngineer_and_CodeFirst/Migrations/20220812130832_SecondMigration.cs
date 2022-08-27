using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_ReverseEngineer_and_CodeFirst.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "Comentarios",
            //    table: "Bikes",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.AddColumn<bool>(
            //    name: "Garantia",
            //    table: "Bikes",
            //    type: "bit",
            //    nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Comentarios",
            //    table: "Bikes");

            //migrationBuilder.DropColumn(
            //    name: "Garantia",
            //    table: "Bikes");
        }
    }
}
