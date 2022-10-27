using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiPolyclinic.Migrations
{
    /// <inheritdoc />
    public partial class m19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Experiance",
                table: "Doctors",
                type: "smallint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Experiance",
                value: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experiance",
                table: "Doctors");
        }
    }
}
