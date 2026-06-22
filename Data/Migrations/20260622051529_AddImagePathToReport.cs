using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebAppReports.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathToReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Report");
        }
    }
}
