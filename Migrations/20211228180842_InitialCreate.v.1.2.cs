using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class InitialCreatev12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DropBoxFolderName",
                table: "VideoCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DropBoxFolderName",
                table: "VideoCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
