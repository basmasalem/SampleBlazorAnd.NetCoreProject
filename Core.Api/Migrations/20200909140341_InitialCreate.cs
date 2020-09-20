using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depatrments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeparmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depatrments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true),
                    BirhtOfDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Depatrments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Depatrments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Depatrments",
                columns: new[] { "DepartmentId", "DeparmentName" },
                values: new object[] { 1, "IT" });

            migrationBuilder.InsertData(
                table: "Depatrments",
                columns: new[] { "DepartmentId", "DeparmentName" },
                values: new object[] { 2, "CS" });

            migrationBuilder.InsertData(
                table: "Depatrments",
                columns: new[] { "DepartmentId", "DeparmentName" },
                values: new object[] { 3, "CIS" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirhtOfDate", "Code", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1982, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "EMP1", 1, "empmohamed@yahoo.com", "mohamed", 0, "salem", "images/icon/avatar-01.jpg" },
                    { 2, new DateTime(1982, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "EMP2", 1, "empAhmed@yahoo.com", "Ahmed", 0, "salem", "images/icon/avatar-03.jpg" },
                    { 3, new DateTime(1982, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "EMP3", 2, "empHana@yahoo.com", "Hana", 1, "salem", "images/icon/avatar-02.jpg" },
                    { 4, new DateTime(1982, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "EMP4", 3, "empLana@yahoo.com", "Lana", 1, "salem", "images/icon/avatar-02.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Depatrments");
        }
    }
}
