using Microsoft.EntityFrameworkCore.Migrations;

namespace NamingConvensionTool.Migrations
{
    public partial class codeInCOuntryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "Country");
        }
    }
}
