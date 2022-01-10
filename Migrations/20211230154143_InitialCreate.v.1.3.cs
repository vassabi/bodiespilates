using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class InitialCreatev13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "VideoCategories",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "VideoCategories");
        }
    }
}
