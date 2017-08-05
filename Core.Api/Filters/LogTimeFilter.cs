using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Filters
{
    public class LogTimeFilter : Attribute, IActionFilter
    {
        public LogTimeFilter()
        {

        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine(string.Format("Action Method {0} executed at {1}", context.ActionDescriptor.DisplayName, DateTime.Now.ToString()), "Web API Logs");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine(string.Format("Action Method {0} executing at {1}", context.ActionDescriptor.DisplayName, DateTime.Now.ToString()), "Web API Logs");
        }
    }
}
