﻿using EmployeeTest.Core.Models.Responses;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EmployeeTest.API.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {

                        var errorRespondMode = new ErrorResponseModel
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message
                        };

                        await context.Response.WriteAsync(errorRespondMode.ToString());
                    }
                });
            });
        }
    }
}
