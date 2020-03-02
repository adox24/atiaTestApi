using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTest.Core.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key)
            : base($"{name} with {key} was not found.")
        {
        }
    }
}