using Microsoft.EntityFrameworkCore.Migrations;

namespace NttProject1.Migrations
{
    public partial class AddBomDetailandBomHead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BomDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildMaterialCode = table.Column<string>(nullable: false),
                    MaterialNum = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BomDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BomHead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomCode = table.Column<string>(nullable: false),
                    MaterialCode = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BomHead", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BomHead_BomCode",
                table: "BomHead",
                column: "BomCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BomDetail");

            migrationBuilder.DropTable(
                name: "BomHead");
        }
    }
}
