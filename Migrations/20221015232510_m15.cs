using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiPolyclinic.Migrations
{
    /// <inheritdoc />
    public partial class m15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Analyzes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Analyzes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Analyzes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Analyzes");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Diagnoses",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Diagnoses",
                newName: "RecordId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Doctors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Diagnoses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "City",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "City",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "City",
                value: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Email", "FirstName", "LastName", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { 11, "", "admin@gmail.com", "Админ", "Админов", "admin", "", 1 },
                    { 12, "", "vanov@gmail.com", "Ваня", "Ванов", "123456", "+79443453535", 2 },
                    { 13, "", "ivan@gmail.com", "Иван", "Иванов", "123456", "+79443453534", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Diagnoses");

            migrationBuilder.RenameColumn(
                name: "RecordId",
                table: "Diagnoses",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Diagnoses",
                newName: "UpdatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Role",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Role",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Role",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Role",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Records",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Records",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Records",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Records",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Doctors",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Doctors",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Doctors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Doctors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Doctors",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Diagnoses",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Diagnoses",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Analyzes",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Analyzes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Analyzes",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Analyzes",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    City = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "Name", "Phone", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), "Иванов Иван Иванович", "8-800-555-35-35", new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 10, 15, 21, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
