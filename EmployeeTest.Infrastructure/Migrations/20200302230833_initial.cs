using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeTest.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(type: "nvarchar(13)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Password = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Role = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "DateOfBirth", "FirstName", "LastName", "Password", "Role", "Salary", "Username" },
                values: new object[,]
                {
                    { new Guid("3bde529f-1c4a-430f-809a-9ebee4ae6fe2"), "Wellfield Road Roath Cardiff", new DateTime(2020, 3, 3, 0, 8, 33, 45, DateTimeKind.Local).AddTicks(8240), "Will", "Smith", "admin", 0, 2000m, "admin" },
                    { new Guid("a80833c4-6080-4c4d-858e-23c9df1ab0b8"), "Wellfield Road Roath Cardiff", new DateTime(2020, 3, 3, 0, 8, 33, 48, DateTimeKind.Local).AddTicks(2517), "test", "test", "test", 0, 2000m, "test" },
                    { new Guid("760dbba7-7d39-4f31-a314-1a2012155801"), "Wellfield Road Roath Cardiff", new DateTime(2020, 3, 3, 0, 8, 33, 48, DateTimeKind.Local).AddTicks(2575), "manager", "manager", "manager", 2, 2000m, "manager" },
                    { new Guid("b4c83d60-5108-42a5-a799-d71b2c1377d0"), "Wellfield Road Roath Cardiff", new DateTime(2020, 3, 3, 0, 8, 33, 48, DateTimeKind.Local).AddTicks(2583), "SuperAdmin", "SuperAdmin", "SuperAdmin", 1, 2000m, "SuperAdmin" },
                    { new Guid("dad01392-8cfe-4af8-acd3-21c1ebcc9c9d"), "Wellfield Road Roath Cardiff", new DateTime(2020, 3, 3, 0, 8, 33, 48, DateTimeKind.Local).AddTicks(2588), "testME", "testME", "testME", 3, 2000m, "testME" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
