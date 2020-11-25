using Microsoft.EntityFrameworkCore.Migrations;

namespace amiba.Web.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "M_Project_IndustryCode",
                table: "M_Budget_Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "M_Project_IndustryName",
                table: "M_Budget_Project",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "M_Project_IndustryCode",
                table: "M_Budget_Project");

            migrationBuilder.DropColumn(
                name: "M_Project_IndustryName",
                table: "M_Budget_Project");
        }
    }
}
