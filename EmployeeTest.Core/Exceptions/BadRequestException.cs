using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTest.Core.Exceptions
{
    public class BadRequestException : Exception
    {

        public BadRequestException(string message)
            : base(message)
        {
        }
    }
}