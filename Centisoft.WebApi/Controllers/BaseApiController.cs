using Centisoft.Core.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Centisoft.WebApi.Controllers
{
    public class BaseApiController : ApiController
    {
        private CustomerFacade customerFacade;
        public BaseApiController()
        {

        }

        protected CustomerFacade TheCustomerFacade
        {
            get
            {
                if (customerFacade == null)
                {
                    customerFacade = new CustomerFacade(this.Request);
                }
                return customerFacade;
            }
        }

    }
}
