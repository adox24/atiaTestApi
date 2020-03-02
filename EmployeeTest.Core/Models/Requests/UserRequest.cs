using EmployeeTest.Core.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTest.Core.Models.Requests
{
   public class UserRequest
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }
        public int Role { get; set; }

        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
}
}
