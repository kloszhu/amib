using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace amiba.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_Budget_Amiba",
                columns: table => new
                {
                    M_Amiba_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_Amiba_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Amiba_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_Amiba_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_Amiba_isvaitual = table.Column<bool>(type: "bit", nullable: true),
                    M_Amiba_effectdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Budget_Amiba", x => x.M_Amiba_id);
                });

            migrationBuilder.CreateTable(
                name: "M_Budget_Orgination",
                columns: table => new
                {
                    M_Organization_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_Organization_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Organization_parent = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Organization_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_Organization_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_Organization_isvaitual = table.Column<bool>(type: "bit", nullable: true),
                    M_Amiba_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Region_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Organization_effectdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Budget_Orgination", x => x.M_Organization_id);
                });

            migrationBuilder.CreateTable(
                name: "M_Budget_Project",
                columns: table => new
                {
                    M_Project_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_Project_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Project_parent = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Project_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_Region_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Amiba_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Project_ProjectType = table.Column<int>(type: "int", nullable: true),
                    M_Project_isvirtual = table.Column<bool>(type: "bit", nullable: true),
                    M_Subject_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Project_CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Budget_Project", x => x.M_Project_id);
                });

            migrationBuilder.CreateTable(
                name: "M_Budget_Region",
                columns: table => new
                {
                    M_Region_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_Region_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Region_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_Region_isvirtual = table.Column<bool>(type: "bit", nullable: false),
                    M_Region_createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Budget_Region", x => x.M_Region_id);
                });

            migrationBuilder.CreateTable(
                name: "M_Budget_ReserveDetail",
                columns: table => new
                {
                    M_Reserve_Detail_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_Reserve_Detail_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Reserve_Main_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Subject_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Subject_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_Subject_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M4 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M5 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M6 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M7 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M8 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M9 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M11 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M12 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M_Reserve_Detail_createdat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Budget_ReserveDetail", x => x.M_Reserve_Detail_id);
                });

            migrationBuilder.CreateTable(
                name: "M_Budget_ReserveMain",
                columns: table => new
                {
                    M_Reserve_Main_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_Reserve_Main_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    P_Business_Flow_Form_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Project_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Reserve_Main_year = table.Column<int>(type: "int", nullable: true),
                    M_Reserve_Main_month = table.Column<int>(type: "int", nullable: true),
                    M_Reserve_Main_day = table.Column<int>(type: "int", nullable: true),
                    M_Amiba_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Reserve_Main_registerdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    M_Reserve_Main_state = table.Column<int>(type: "int", nullable: true),
                    M_Reserve_Main_createdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Budget_ReserveMain", x => x.M_Reserve_Main_id);
                });

            migrationBuilder.CreateTable(
                name: "M_Budget_Subject",
                columns: table => new
                {
                    M_Subject_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_Subject_code = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Subject_number = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    M_Subject_isShow = table.Column<bool>(type: "bit", nullable: true),
                    M_Subject_isReadOnly = table.Column<bool>(type: "bit", nullable: true),
                    M_Subject_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Budget_Subject", x => x.M_Subject_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Budget_Amiba");

            migrationBuilder.DropTable(
                name: "M_Budget_Orgination");

            migrationBuilder.DropTable(
                name: "M_Budget_Project");

            migrationBuilder.DropTable(
                name: "M_Budget_Region");

            migrationBuilder.DropTable(
                name: "M_Budget_ReserveDetail");

            migrationBuilder.DropTable(
                name: "M_Budget_ReserveMain");

            migrationBuilder.DropTable(
                name: "M_Budget_Subject");
        }
    }
}
