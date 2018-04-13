using Centisoft.Core.ModelModel;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.DAL
{
    public class CustomerRepo : BaseRepo
    {
        private ModelFactory modelFactory;

        public CustomerRepo(HttpRequestMessage request)
        {
            modelFactory = new ModelFactory(request);
        }
        public List<CustomerModel> LoadAll()
        {
            return context.Customers.ToList().Select(modelFactory.Create).ToList();
        }

        public Customer Load(int id)
        {
            return context.Customers.FirstOrDefault(x => x.Id == id);
        }

        public void Save(int? id,CustomerModel cm)
        {
            if (id != null)
            {
                cm.Id = id.Value;
            }
            Customer c = modelFactory.Create(cm);
            if (c.Id > 0)
            {
                context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Customer c = Load(id);
            context.Customers.Remove(c);
        }
    }
}

