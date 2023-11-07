using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Woof.Migrations
{
    /// <inheritdoc />
    public partial class ploise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RegNr",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -5,
                columns: new[] { "BirthDate", "Color", "FatherDogID", "Merits", "MotherDogID", "Name", "Nickname", "RegNr", "Sex", "Size", "Titles" },
                values: new object[] { new DateTime(2011, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black & White", null, null, null, "Edelweiss Dirty Sexy Money", "Lexee", "TS07482701", "Female", "Tiny", "AMCH - Gold Grand Champion" });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogID", "BirthDate", "BroodID", "Color", "CountryID", "CurrentOwnerID", "DeathDate", "Description", "FatherDogID", "Hairlayers", "LitterID", "Merits", "MotherDogID", "Name", "Nickname", "OriginalBreederID", "RegNr", "Sex", "Size", "Titles" },
                values: new object[,]
                {
                    { -8, new DateTime(2015, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Black & White", 1, null, null, "This is a sample dog description.", -4, "Hairless", null, null, -5, "Edelweiss Too Sexy For Your Party At Blacks", "Venus", null, null, "Female", "31.75cm (12.5inches) / 5kg", "AMCH - BronzeGCH" },
                    { -7, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Black and white", 1, null, null, "This is a sample dog description.", null, "Powderpuff", null, null, null, "Hi-Life's Tang Gao Of The Sun", null, null, "TR45790401", "Female", "31,75cm (12.5inches)", null },
                    { -6, new DateTime(2005, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, null, null, null, null, "Hairless", null, null, null, "Expression-All Fired Up", "Fire", null, " TR43989201", "Male", null, "AMCH" },
                    { -4, new DateTime(2011, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cream", 1, null, null, "This is a sample dog description.", null, "Powderpuff", null, "Ok in Show", null, "Edelweiss Natalie's Mountain Man SOM", "Jake", null, "TS06970704", "Male", "Medium", "AMCH" },
                    { -3, null, null, "Dotted", 1, null, null, "This is a sample dog description.", -6, "Testing", null, null, -7, "Hi-Life's Sirius Image of the Sun at Zen", null, null, null, "Female", "Medium", null },
                    { -2, new DateTime(2015, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "White", 1, null, null, "This is a sample dog description.", -4, "Hairless", null, "Best in Show", -5, "Edelweiss Too Sexy for my Shirt", null, null, null, "Male", "Small", "ACCCCH" },
                    { -1, new DateTime(2017, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brown", 1, null, null, "This is a sample dog description.", -2, "Hairless", null, "Best in Show", -3, "Hi-Life's Grand Finale", "Prince", null, "TS33817204", "Male", "Medium", "ACCCCH" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -1);

            migrationBuilder.AlterColumn<string>(
                name: "RegNr",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: -5,
                columns: new[] { "BirthDate", "Color", "FatherDogID", "Merits", "MotherDogID", "Name", "Nickname", "RegNr", "Sex", "Size", "Titles" },
                values: new object[] { new DateTime(2017, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", 9, "Best in Show", 10, "Hi-Life's Grand Finale", "Prince", "TS33817204", "Male", "Medium", "ACCCCH" });
        }
    }
}
