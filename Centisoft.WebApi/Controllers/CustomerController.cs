using Centisoft.Core.BLL;
using Centisoft.Core.DAL;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Centisoft.WebApi.Filters;
using Centisoft.Core.ModelModel;

namespace Centisoft.WebApi.Controllers
{
    public class CustomerController : BaseApiController
    {

        public CustomerController()
        {
        }
        // GET: api/Customer
        [MigHeader]
        public List<CustomerModel> Get()
        {
            var customers = TheCustomerFacade.FindAllCustomers();
            Console.WriteLine(customers.First().Url);
            return customers;
        }
        // GET: api/Customer/5
        public CustomerModel Get(int id)
        {
            return TheCustomerFacade.FindCustomer(id);
        }

        // POST: api/Customer
        public void Post([FromBody]CustomerModel customer)
        {
            TheCustomerFacade.CreateCustomer(customer);
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]CustomerModel customer)
        {
            
            TheCustomerFacade.UpdateCustomer(id, customer);
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
            TheCustomerFacade.DeleteCustomer(id);
        }
    }
}
