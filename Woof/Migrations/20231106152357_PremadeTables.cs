using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Woof.Migrations
{
    /// <inheritdoc />
    public partial class PremadeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 3, "Gold" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "KennelID", "Password", "RegistrationDate", "RoleID", "Username" },
                values: new object[,]
                {
                    { 1, "admin@admin", null, "admin", new DateTime(2023, 11, 6, 16, 23, 57, 721, DateTimeKind.Local).AddTicks(665), 4, "Admin" },
                    { 2, "bronze@bronze", null, "bronze", new DateTime(2023, 11, 6, 16, 23, 57, 721, DateTimeKind.Local).AddTicks(701), 1, "Bronze" },
                    { 3, "silver@silver", null, "silver", new DateTime(2023, 11, 6, 16, 23, 57, 721, DateTimeKind.Local).AddTicks(707), 2, "Silver" },
                    { 4, "gold@gold", null, "gold", new DateTime(2023, 11, 6, 16, 23, 57, 721, DateTimeKind.Local).AddTicks(712), 3, "Gold" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);
        }
    }
}
