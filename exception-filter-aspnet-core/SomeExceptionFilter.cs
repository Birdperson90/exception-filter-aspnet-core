using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ExceptionFilterAspNetCore
{
    public class SomeExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (!(context.Exception is SomeException))
            {
                return;
            }

            context.Result = new BadRequestObjectResult(new
            {
                context.Exception.Message,
                context.Exception
            }); // pretending is a bad request result
        }
    }
}
