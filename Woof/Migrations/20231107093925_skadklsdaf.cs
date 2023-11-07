﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Woof.Migrations
{
    /// <inheritdoc />
    public partial class skadklsdaf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 7, 10, 39, 25, 629, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 7, 10, 39, 25, 629, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 7, 10, 39, 25, 629, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 7, 10, 39, 25, 629, DateTimeKind.Local).AddTicks(9139));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 7, 10, 38, 45, 371, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 7, 10, 38, 45, 371, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 7, 10, 38, 45, 371, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 7, 10, 38, 45, 371, DateTimeKind.Local).AddTicks(4409));
        }
    }
}
