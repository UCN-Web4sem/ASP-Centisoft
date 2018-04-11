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

namespace Centisoft.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        private CustomerFacade cFacade;

        public CustomerController()
        {
            this.cFacade = new CustomerFacade();
        }
        // GET: api/Customer
        [MigHeader]
        public List<Customer> Get()
        {
            return cFacade.FindAllCustomers();
        }

        // GET: api/Customer/5
        public Customer Get(int id)
        {
            return cFacade.FindCustomer(id);
        }

        // POST: api/Customer
        public void Post([FromBody]Customer customer)
        {
            cFacade.CreateCustomer(customer);
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]Customer customer)
        {
            cFacade.UpdateCustomer(customer);
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
            cFacade.DeleteCustomer(id);
        }
    }
}
