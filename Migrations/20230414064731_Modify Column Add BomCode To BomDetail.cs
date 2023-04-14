using Microsoft.EntityFrameworkCore.Migrations;

namespace NttProject1.Migrations
{
    public partial class ModifyColumnAddBomCodeToBomDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BomCode",
                table: "BomDetail",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BomCode",
                table: "BomDetail");
        }
    }
}
