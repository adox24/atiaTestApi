using EmployeeTest.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTest.Infrastructure.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData
                (
                  new User
                  {
                      Id = Guid.NewGuid(),
                      Username = "admin",
                      FirstName = "Will",
                      LastName = "Smith",
                      Password = "admin",
                      Address = "Wellfield Road Roath Cardiff",
                      Role = Core.Entities.Enums.RoleTypeEnum.Admin,
                      DateOfBirth = DateTime.Now,
                      Salary = 2000
                  },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Username = "test",
                        FirstName = "test",
                        LastName = "test",
                        Password = "test",
                        Address = "Wellfield Road Roath Cardiff",
                        Role = Core.Entities.Enums.RoleTypeEnum.Admin,
                        DateOfBirth = DateTime.Now,
                        Salary = 2000
                    },
                       new User
                       {
                           Id = Guid.NewGuid(),
                           Username = "manager",
                           FirstName = "manager",
                           LastName = "manager",
                           Password = "manager",
                           Address = "Wellfield Road Roath Cardiff",
                           Role = Core.Entities.Enums.RoleTypeEnum.Manager,
                           DateOfBirth = DateTime.Now,
                           Salary = 2000
                       },
                        new User
                        {
                            Id = Guid.NewGuid(),
                            Username = "SuperAdmin",
                            FirstName = "SuperAdmin",
                            LastName = "SuperAdmin",
                            Password = "SuperAdmin",
                            Address = "Wellfield Road Roath Cardiff",
                            Role = Core.Entities.Enums.RoleTypeEnum.SuperAdmin,
                            DateOfBirth = DateTime.Now,
                            Salary = 2000
                        },
                         new User
                         {
                             Id = Guid.NewGuid(),
                             Username = "testME",
                             FirstName = "testME",
                             LastName = "testME",
                             Password = "testME",
                             Address = "Wellfield Road Roath Cardiff",
                             Role = Core.Entities.Enums.RoleTypeEnum.User,
                             DateOfBirth = DateTime.Now,
                             Salary = 2000
                         }
                );
        }
        public DbSet<User> Users { get; set; }
    }
}