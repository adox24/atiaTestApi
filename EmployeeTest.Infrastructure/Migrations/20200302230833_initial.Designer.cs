﻿// <auto-generated />
using System;
using EmployeeTest.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeTest.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200302230833_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeTest.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3bde529f-1c4a-430f-809a-9ebee4ae6fe2"),
                            Address = "Wellfield Road Roath Cardiff",
                            DateOfBirth = new DateTime(2020, 3, 3, 0, 8, 33, 45, DateTimeKind.Local).AddTicks(8240),
                            FirstName = "Will",
                            LastName = "Smith",
                            Password = "admin",
                            Role = 0,
                            Salary = 2000m,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("a80833c4-6080-4c4d-858e-23c9df1ab0b8"),
                            Address = "Wellfield Road Roath Cardiff",
                            DateOfBirth = new DateTime(2020, 3, 3, 0, 8, 33, 48, DateTimeKind.Local).AddTicks(2517),
                            FirstName = "test",
                            LastName = "test",
                            Password = "test",
                            Role = 0,
                            Salary = 2000m,
                            Username = "test"
                        },
                        new
                        {
                            Id = new Guid("760dbba7-7d39-4f31-a314-1a2012155801"),
                            Address = "Wellfield Road Roath Cardiff",
                            DateOfBirth = new DateTime(2020, 3, 3, 0, 8, 33, 48, DateTimeKind.Local).AddTicks(2575),
                            FirstName = "manager",
                            LastName = "manager",
                            Password = "manager",
                            Role = 2,
                            Salary = 2000m,
                            Username = "manager"
                        },
                        new
                        {
                            Id = new Guid("b4c83d60-5108-42a5-a799-d71b2c1377d0"),
                            Address = "Wellfield Road Roath Cardiff",
                            DateOfBirth = new DateTime(2020, 3, 3, 0, 8, 33, 48, DateTimeKind.Local).AddTicks(2583),
                            FirstName = "SuperAdmin",
                            LastName = "SuperAdmin",
                            Password = "SuperAdmin",
                            Role = 1,
                            Salary = 2000m,
                            Username = "SuperAdmin"
                        },
                        new
                        {
                            Id = new Guid("dad01392-8cfe-4af8-acd3-21c1ebcc9c9d"),
                            Address = "Wellfield Road Roath Cardiff",
                            DateOfBirth = new DateTime(2020, 3, 3, 0, 8, 33, 48, DateTimeKind.Local).AddTicks(2588),
                            FirstName = "testME",
                            LastName = "testME",
                            Password = "testME",
                            Role = 3,
                            Salary = 2000m,
                            Username = "testME"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}