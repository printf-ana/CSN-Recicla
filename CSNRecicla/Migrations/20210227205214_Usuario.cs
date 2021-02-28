using Microsoft.EntityFrameworkCore.Migrations;

namespace CSNRecicla.Migrations
{
    public partial class Usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PontoDeColetas_AspNetUsers_UsuarioId1",
                table: "PontoDeColetas");

            migrationBuilder.DropIndex(
                name: "IX_PontoDeColetas_UsuarioId1",
                table: "PontoDeColetas");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "PontoDeColetas");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "PontoDeColetas",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_PontoDeColetas_UsuarioId",
                table: "PontoDeColetas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_PontoDeColetas_AspNetUsers_UsuarioId",
                table: "PontoDeColetas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PontoDeColetas_AspNetUsers_UsuarioId",
                table: "PontoDeColetas");

            migrationBuilder.DropIndex(
                name: "IX_PontoDeColetas_UsuarioId",
                table: "PontoDeColetas");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "PontoDeColetas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId1",
                table: "PontoDeColetas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PontoDeColetas_UsuarioId1",
                table: "PontoDeColetas",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PontoDeColetas_AspNetUsers_UsuarioId1",
                table: "PontoDeColetas",
                column: "UsuarioId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
