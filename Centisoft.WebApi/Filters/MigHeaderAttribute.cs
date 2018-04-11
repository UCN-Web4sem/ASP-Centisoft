using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Centisoft.WebApi.Filters
{
    public class MigHeaderAttribute : ActionFilterAttribute 
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            base.OnActionExecuting(actionContext);
            Trace.WriteLine(string.Format("Action Method {0}, was exe at {1}", actionContext.ActionDescriptor.ActionName, DateTime.Now));
        }
    }
}