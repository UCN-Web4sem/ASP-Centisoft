using Centisoft.Core.DAL;
using Centisoft.Core.ModelModel;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.BLL
{
    public class CustomerFacade
    {
        private CustomerRepo CustomerRepo;
        private ModelFactory modelFactory;
        public CustomerFacade(HttpRequestMessage request)
        {
            CustomerRepo = new CustomerRepo(request);
            modelFactory = new ModelFactory(request);
        }

        public void CreateCustomer(CustomerModel Customer)
        {
            CustomerRepo.Save(null, Customer);
        }

        public void DeleteCustomer(int id)
        {
            CustomerRepo.Delete(id);
        }

        public CustomerModel FindCustomer(int id)
        {
            return CustomerRepo.Load(id);
        }

        public List<CustomerModel> FindAllCustomers()
        {
            return CustomerRepo.LoadAll();
        }

        public void UpdateCustomer(int id, CustomerModel customer)
        {
            CustomerRepo.Save(id, customer);
        }
    }
}
