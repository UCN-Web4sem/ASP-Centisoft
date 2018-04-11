using Centisoft.Core.DAL;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.BLL
{
    public class CustomerFacade
    {
        private CustomerRepo CustomerRepo;
        public CustomerFacade()
        {
            CustomerRepo = new CustomerRepo();
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

        public List<Customer> FindAllCustomers()
        {
            return CustomerRepo.LoadAll();
        }

        public void UpdateCustomer(Customer customer)
        {
            CustomerRepo.Save(customer);
        }
    }
}
