using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.DAL
{
    public class DeveloperRepo : BaseRepo
    {
        public List<Developer> LoadAll(int accountId)
        {
            return context.Developers.Where(x => x.AccountId == accountId).ToList();
        }

        public Developer Load(int id)
        {
            return context.Developers.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Developer dev)
        {
            if (dev.Id > 0)
            {
                context.Entry(dev).State = System.Data.Entity.EntityState.Modified;
                //Developer existingdeveloper = Load(dev.Id);
                //existingdeveloper.Name = dev.Name;
                //existingdeveloper.Email = dev.Email;
                //existingdeveloper.AccountId = dev.AccountId;
            }
            else
            {
              
                context.Developers.Add(dev);
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Developer dev = Load(id);
            context.Developers.Remove(dev);
        }
    }
}
