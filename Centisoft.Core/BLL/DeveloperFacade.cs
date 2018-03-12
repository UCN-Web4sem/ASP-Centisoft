using Centisoft.Core.Contracts;
using Centisoft.Core.DAL;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.BLL
{
    public class DeveloperFacade : IDeveloperFacade
    {
        private IGenericInterface<Developer> developerRepo;
        public DeveloperFacade(IGenericInterface<Developer> developerRepo)
        {
            this.developerRepo = developerRepo;
        }

        public void CreateDeveloper(Developer developer)
        {
            developerRepo.Save(developer);
        }

        public void DeleteDeveloper(int id)
        {
            Developer dev = developerRepo.Get(id);
            developerRepo.Delete(dev);
        }

        public Developer FindDeveloper(int id)
        {
            return developerRepo.Get(id);
        }

        public List<Developer> FindAllDevelopers()
        {
            return developerRepo.GetAll();
        }

        public void UpdateDeveloepr(Developer dev)
        {
            developerRepo.Save(dev);
        }        
    }
}
