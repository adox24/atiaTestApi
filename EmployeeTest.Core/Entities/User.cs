using EmployeeTest.Core.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmployeeTest.Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(13)")]
        public string Username { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        public string FirstName { get; set; }
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Address { get; set; }
        public RoleTypeEnum Role { get; set; }

        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }
    }
}
