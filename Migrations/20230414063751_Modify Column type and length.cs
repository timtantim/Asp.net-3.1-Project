using Microsoft.EntityFrameworkCore.Migrations;

namespace NttProject1.Migrations
{
    public partial class ModifyColumntypeandlength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaterialCode",
                table: "BomHead",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BomCode",
                table: "BomHead",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "MaterialNum",
                table: "BomDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ChildMaterialCode",
                table: "BomDetail",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaterialCode",
                table: "BomHead",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BomCode",
                table: "BomHead",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "MaterialNum",
                table: "BomDetail",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ChildMaterialCode",
                table: "BomDetail",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);
        }
    }
}
