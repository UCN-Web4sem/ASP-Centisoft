using Centisoft.Core.DAL;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Centisoft.WebApi.Filters
{
    public class SecurityAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            base.OnActionExecuting(actionContext);
            string sToken = "bla bla bla";
            HttpResponseMessage responeMsg = new HttpResponseMessage();
            ClientRepo repo = new ClientRepo();
            Client client = null;
            if(actionContext.Request.Headers.Contains(sToken))
            {
                IEnumerable<string> headerValues = actionContext.Request.Headers.GetValues(sToken);
                string token = headerValues.FirstOrDefault();
                client = repo.Load(Int32.Parse(token));
                if (client == null)
                {
                    responeMsg.StatusCode = HttpStatusCode.Forbidden;
                    responeMsg.ReasonPhrase = "Invalid or expired auth token";
                }
                else
                {
                    responeMsg.StatusCode = HttpStatusCode.OK;
                    responeMsg.ReasonPhrase = "Token validated";
                    responeMsg.Content = new StringContent(client.Id.ToString());
                }
            }
            else
            {
                responeMsg.StatusCode = HttpStatusCode.Forbidden;
                responeMsg.ReasonPhrase = "No token";
            }
            actionContext.Response = responeMsg;
        }
    }
}