using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;

namespace MonthlyBillsWebAPI
{
    public class ModelVerify : Attribute, IActionFilter  // I suspect that the body is coming in to the put request with single quotes (that's how it appears if I print it in python.
                                                            // Alternatively it might just need to be a string instead of a dict??
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers["Auth"] == "")
            {
                //context.Result = new UnauthorizedResult();
                StreamReader reader = new StreamReader(context.HttpContext.Request.Body, Encoding.UTF8);
                var body = context.HttpContext.Request.Body;
              
            }

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var output = context.Result;
        }
    }
}
