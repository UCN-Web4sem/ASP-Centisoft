using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.Contracts
{
    public interface IDeveloperFacade
    {
        void CreateDeveloper(Developer developer);

        void DeleteDeveloper(int id);

        Developer FindDeveloper(int id);

        List<Developer> FindAllDevelopers();

        void UpdateDeveloepr(Developer dev);
        
    }
}
