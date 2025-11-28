using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagrment.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(1294), new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(1308), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(1480), new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(1482), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(1926), new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(1928), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(1931), new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(1932), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(2142), new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(2143), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(2147), new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(2148), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(2151), new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(2153), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(2156), new DateTime(2025, 11, 24, 11, 44, 31, 207, DateTimeKind.Local).AddTicks(2157), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
