using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiPolyclinic.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Purpose",
                table: "Records",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "Diagnos",
                table: "Records",
                newName: "Phone");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Records",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Records",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Records",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Records");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Records",
                newName: "Purpose");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Records",
                newName: "Diagnos");
        }
    }
}
