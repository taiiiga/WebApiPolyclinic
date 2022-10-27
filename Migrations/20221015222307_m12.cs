using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiPolyclinic.Migrations
{
    /// <inheritdoc />
    public partial class m12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Records");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Records",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Records");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Records",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
