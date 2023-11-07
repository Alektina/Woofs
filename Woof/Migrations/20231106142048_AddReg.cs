using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Woof.Migrations
{
    /// <inheritdoc />
    public partial class AddReg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegNr",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegNr",
                table: "Dogs");
        }
    }
}
