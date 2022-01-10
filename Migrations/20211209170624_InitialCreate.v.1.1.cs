using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class InitialCreatev11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Suspended",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Suspended",
                table: "Users");
        }
    }
}
