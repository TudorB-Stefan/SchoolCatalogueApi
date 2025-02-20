using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolCatalogueApi.Migrations
{
    /// <inheritdoc />
    public partial class AutomationDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgGrade",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Grades",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grades",
                table: "Students");

            migrationBuilder.AddColumn<double>(
                name: "AvgGrade",
                table: "Students",
                type: "float",
                nullable: true);
        }
    }
}
