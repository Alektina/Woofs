using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Woof.Migrations
{
    /// <inheritdoc />
    public partial class asgfdhg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Users_CurrentOwnerID",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Users_OriginalBreederID",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_CurrentOwnerID",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_OriginalBreederID",
                table: "Dogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Dogs_CurrentOwnerID",
                table: "Dogs",
                column: "CurrentOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_OriginalBreederID",
                table: "Dogs",
                column: "OriginalBreederID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Users_CurrentOwnerID",
                table: "Dogs",
                column: "CurrentOwnerID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Users_OriginalBreederID",
                table: "Dogs",
                column: "OriginalBreederID",
                principalTable: "Users",
                principalColumn: "UserID");
        }
    }
}
