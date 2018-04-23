using Centisoft.Core.ModelModel;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Routing;

namespace Centisoft.Core.DAL
{
    public class ModelFactory
    {
        private UrlHelper urlHelper;

        public ModelFactory(HttpRequestMessage request)
        {
            urlHelper = new UrlHelper(request);
        }

        public CustomerModel Create(Customer customer)
        {
            return new CustomerModel
            {
                Name = customer.Name,
                Address = customer.Address,
                Address2 = customer.Address2,
                City = customer.City,
                Country = customer.Country,
                Email = customer.Email,
                Phone = customer.Phone,
                Zip = customer.Zip,
                Url = urlHelper.Link("DefaultApi", new { id = customer.Id })

            };
            
        }

        public Customer Create(int id, CustomerModel customerModel)
        {
            //var routeDate = urlHelper.Request.GetRouteData();
            //int id = int.Parse(routeDate.Values["id"].ToString());
            return new Customer
            {
                Id = id,
                Address = customerModel.Address,
                Address2 = customerModel.Address2,
                City = customerModel.City,
                Country = customerModel.Country,
                Email = customerModel.Email,
                Name = customerModel.Name,
                Phone = customerModel.Phone,
                Zip = customerModel.Zip,
                Client = null, // TODO:
                Projects = null // TODO:
            };
        }
    }
}
