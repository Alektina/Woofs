using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Woof.Migrations
{
    /// <inheritdoc />
    public partial class SeedTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogID", "BirthDate", "BroodID", "Color", "CountryID", "CurrentOwnerID", "DeathDate", "Description", "FatherDogID", "Hairlayers", "LitterID", "Merits", "MotherDogID", "Name", "Nickname", "OriginalBreederID", "RegNr", "Sex", "Size", "Titles" },
                values: new object[] { -5, new DateTime(2017, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brown", 1, null, null, "This is a sample dog description.", 9, "Hairless", null, "Best in Show", 10, "Hi-Life's Grand Finale", "Prince", null, "TS33817204", "Male", "Medium", "ACCCCH" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -5);
        }
    }
}
