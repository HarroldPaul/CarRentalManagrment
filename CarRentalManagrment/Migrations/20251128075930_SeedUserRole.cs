using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagrment.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(5785), new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(5798), new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6012), new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6014), new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6102), new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6103), new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6105), new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6107), new DateTime(2025, 11, 28, 15, 59, 29, 657, DateTimeKind.Local).AddTicks(6107) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6624), new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6639), new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6841), new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6842), new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6927), new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6929), new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6930), new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6932), new DateTime(2025, 11, 28, 15, 30, 51, 601, DateTimeKind.Local).AddTicks(6932) });
        }
    }
}
