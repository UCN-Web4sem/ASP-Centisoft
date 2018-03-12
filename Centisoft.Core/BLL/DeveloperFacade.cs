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
        private IgenericInterface<Developer> developerRepo;
        public DeveloperFacade(IgenericInterface<Developer> developerRepo)
        {
            this.developerRepo = developerRepo;
        }

        public void CreateDeveloper(Developer developer)
        {
            developerRepo.Save(developer);
        }

        public void deleteDeveloper(int id)
        {
            Developer dev = developerRepo.Get(id);
            developerRepo.Delete(dev);
        }

        public Developer findDeveloper(int id)
        {
            return developerRepo.Get(id);
        }

        public List<Developer> findAllDevelopers()
        {
            return developerRepo.GetAll();
        }

        public void updateDeveloepr(Developer dev)
        {
            developerRepo.Save(dev);
        }        
    }
}
