using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centisoft.Core.Contracts;
using Centisoft.Core.Models;

namespace Centisoft.Core.DAL
{
    public class TestingDeveloperRepo : IGenericInterface<Developer>
    {
        public List<Developer> TheDeveloperList { get; set; }
        public void Delete(Developer t)
        {
            TheDeveloperList.Remove(t);
        }

        public Developer Get(int id)
        {
            return TheDeveloperList.Find(x => x.Id == id);            
        }

        public List<Developer> GetAll()
        {
            return TheDeveloperList;
        }

        public void Save(Developer t)
        {
            TheDeveloperList.Add(t);
        }
    }
}
