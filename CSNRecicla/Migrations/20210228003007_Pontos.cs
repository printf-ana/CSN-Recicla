using Microsoft.EntityFrameworkCore.Migrations;

namespace CSNRecicla.Migrations
{
    public partial class Pontos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "AspNetUsers");
        }
    }
}
