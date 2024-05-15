using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBEmpresa.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoID);
                });

            migrationBuilder.CreateTable(
                name: "RolesEmpleados",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesEmpleados", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "Subdepartamentos",
                columns: table => new
                {
                    SubdepartamentoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subdepartamentos", x => x.SubdepartamentoID);
                    table.ForeignKey(
                        name: "FK_Subdepartamentos_Departamentos_DepartamentoID",
                        column: x => x.DepartamentoID,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaContratacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartamentoID = table.Column<int>(type: "int", nullable: false),
                    DepartamentoID1 = table.Column<int>(type: "int", nullable: false),
                    SubdepartamentoID = table.Column<int>(type: "int", nullable: false),
                    SubdepartamentoID1 = table.Column<int>(type: "int", nullable: false),
                    RolID = table.Column<int>(type: "int", nullable: false),
                    RolEmpleadoRolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoID);
                    table.ForeignKey(
                        name: "FK_Empleados_Departamentos_DepartamentoID",
                        column: x => x.DepartamentoID,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Departamentos_DepartamentoID1",
                        column: x => x.DepartamentoID1,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_RolesEmpleados_RolEmpleadoRolID",
                        column: x => x.RolEmpleadoRolID,
                        principalTable: "RolesEmpleados",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_RolesEmpleados_RolID",
                        column: x => x.RolID,
                        principalTable: "RolesEmpleados",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Subdepartamentos_SubdepartamentoID",
                        column: x => x.SubdepartamentoID,
                        principalTable: "Subdepartamentos",
                        principalColumn: "SubdepartamentoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Subdepartamentos_SubdepartamentoID1",
                        column: x => x.SubdepartamentoID1,
                        principalTable: "Subdepartamentos",
                        principalColumn: "SubdepartamentoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sueldos",
                columns: table => new
                {
                    SueldoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadoID = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sueldos", x => x.SueldoID);
                    table.ForeignKey(
                        name: "FK_Sueldos_Empleados_EmpleadoID",
                        column: x => x.EmpleadoID,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamentoID",
                table: "Empleados",
                column: "DepartamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamentoID1",
                table: "Empleados",
                column: "DepartamentoID1");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_RolEmpleadoRolID",
                table: "Empleados",
                column: "RolEmpleadoRolID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_RolID",
                table: "Empleados",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SubdepartamentoID",
                table: "Empleados",
                column: "SubdepartamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SubdepartamentoID1",
                table: "Empleados",
                column: "SubdepartamentoID1");

            migrationBuilder.CreateIndex(
                name: "IX_Subdepartamentos_DepartamentoID",
                table: "Subdepartamentos",
                column: "DepartamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Sueldos_EmpleadoID",
                table: "Sueldos",
                column: "EmpleadoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sueldos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "RolesEmpleados");

            migrationBuilder.DropTable(
                name: "Subdepartamentos");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
