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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
