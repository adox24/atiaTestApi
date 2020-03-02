﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTest.Core.Models.Responses
{
    public class ErrorResponseModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
