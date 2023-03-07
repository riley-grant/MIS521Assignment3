using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment3_SP2023_rggrant1.Data.Migrations
{
    public partial class changeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Actor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actor_MovieId",
                table: "Actor",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movie_MovieId",
                table: "Actor",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movie_MovieId",
                table: "Actor");

            migrationBuilder.DropIndex(
                name: "IX_Actor_MovieId",
                table: "Actor");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Actor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
