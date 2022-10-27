using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiPolyclinic.Migrations
{
    /// <inheritdoc />
    public partial class m9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
