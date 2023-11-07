using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Woof.Migrations
{
    /// <inheritdoc />
    public partial class Desctest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Broods_BroodID",
                table: "Dogs");

            migrationBuilder.AlterColumn<int>(
                name: "BroodID",
                table: "Dogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Broods_BroodID",
                table: "Dogs",
                column: "BroodID",
                principalTable: "Broods",
                principalColumn: "BroodID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Broods_BroodID",
                table: "Dogs");

            migrationBuilder.AlterColumn<int>(
                name: "BroodID",
                table: "Dogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Broods_BroodID",
                table: "Dogs",
                column: "BroodID",
                principalTable: "Broods",
                principalColumn: "BroodID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
