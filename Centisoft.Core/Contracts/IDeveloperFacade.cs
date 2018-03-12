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

        void deleteDeveloper(int id);

        Developer findDeveloper(int id);

        List<Developer> findAllDevelopers();

        void updateDeveloepr(Developer dev);
        
    }
}
