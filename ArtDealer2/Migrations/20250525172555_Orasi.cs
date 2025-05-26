using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtDealer2.Migrations
{
    /// <inheritdoc />
    public partial class Orasi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obras_Artistas_ArtistaId",
                table: "Obras");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistaId",
                table: "Obras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_Artistas_ArtistaId",
                table: "Obras",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obras_Artistas_ArtistaId",
                table: "Obras");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistaId",
                table: "Obras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_Artistas_ArtistaId",
                table: "Obras",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id");
        }
    }
}
