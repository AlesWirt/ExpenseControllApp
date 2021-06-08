using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut_MVC.Migrations
{
    public partial class fixCategoryMistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cateories",
                table: "Cateories");

            migrationBuilder.RenameTable(
                name: "Cateories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Cateories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cateories",
                table: "Cateories",
                column: "Id");
        }
    }
}
