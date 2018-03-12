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

        public void deleteCustomer(int id)
        {
            CustomerRepo.Delete(id);
        }

        public Customer findCustomer(int id)
        {
            return CustomerRepo.Load(id);
        }

        public List<Customer> findAllCustomers()
        {
            return CustomerRepo.LoadAll();
        }

        public void updateDeveloepr(Customer customer)
        {
            CustomerRepo.Save(customer);
        }
    }
}
