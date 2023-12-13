using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeDatabase.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "deptID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descreption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProject",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false),
                    ProjectsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProject", x => new { x.EmployeesID, x.ProjectsID });
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Employees_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Projects_ProjectsID",
                        column: x => x.ProjectsID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_deptID",
                table: "Employees",
                column: "deptID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_ProjectsID",
                table: "EmployeeProject",
                column: "ProjectsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_deptID",
                table: "Employees",
                column: "deptID",
                principalTable: "Departments",
                principalColumn: "DepId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_deptID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeeProject");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Employees_deptID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProjID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "deptID",
                table: "Employees");
        }
    }
}
