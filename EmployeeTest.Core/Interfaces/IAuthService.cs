using EmployeeTest.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTest.Core.Interfaces
{
    public interface IAuthService
    {
        public LoginResponseModel LoginUser(string Username, string Password);
    }
}
