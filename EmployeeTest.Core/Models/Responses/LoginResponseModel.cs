using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace EmployeeTest.Core.Models.Responses
{
   public class LoginResponseModel
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
    }
}
