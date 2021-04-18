using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleCMS.Data.Migrations
{
    public partial class addnavName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NavName",
                table: "Pages",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NavName",
                table: "Pages");
        }
    }
}
