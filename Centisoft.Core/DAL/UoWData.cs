using Centisoft.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centisoft.Core.Models;
using Centisoft.Core.DAL;

namespace Centisoft.Core.BLL
{
    public class UoWData : IUoW
    {
        public IGenericInterface<Customer> CustomerRepo { get ; set ; }
        public IGenericInterface<Developer> DeveloperRepo { get ; set ; }

        private CentisoftContext context;

        public UoWData()
        {
            context = new CentisoftContext();
            CustomerRepo = new GenericRepo<Customer>(context);
            DeveloperRepo = new GenericRepo<Developer>(context);
        }


        public void Commit()
        {
            context.SaveChanges();
        }


    }
    
}
