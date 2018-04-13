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

        public void CreateCustomer(Customer Customer)
        {
            CustomerRepo.Save(Customer);
        }

        public void DeleteCustomer(int id)
        {
            CustomerRepo.Delete(id);
        }

        public Customer FindCustomer(int id)
        {
            return CustomerRepo.Load(id);
        }

        public List<CustomerModel> FindAllCustomers()
        {
            return CustomerRepo.LoadAll();
        }

        public void UpdateCustomer(Customer customer)
        {
            CustomerRepo.Save(customer);
        }
    }
}
