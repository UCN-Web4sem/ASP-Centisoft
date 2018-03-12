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
        private IUoW UoW;
        public DeveloperFacade(IUoW UoW)
        {
            this.UoW = UoW;
        }

        public void CreateDeveloper(Developer developer)
        {
            UoW.DeveloperRepo.Save(developer);
            UoW.Commit();
        }

        public void DeleteDeveloper(int id)
        {
            Developer dev = UoW.DeveloperRepo.Get(id);
            UoW.DeveloperRepo.Delete(dev);
            UoW.Commit();
        }

        public Developer FindDeveloper(int id)
        {
            return UoW.DeveloperRepo.Get(id);
        }

        public List<Developer> FindAllDevelopers()
        {
            return UoW.DeveloperRepo.GetAll();
        }

        public void UpdateDeveloepr(Developer dev)
        {
            UoW.DeveloperRepo.Save(dev);
            UoW.Commit();
        }        
    }
}
