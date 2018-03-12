using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.DAL
{
    public class ClientRepo : BaseRepo
    {
        public List<Client> LoadAll()
        {
            return context.Clients.ToList();
        }

        public Client Load(int id)
        {
            return context.Clients.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Client client)
        {
            if (client.Id > 0)
            {
                context.Entry(client).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                context.Clients.Add(client);
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Client c = Load(id);
            context.Clients.Remove(c);
        }
    }
}
