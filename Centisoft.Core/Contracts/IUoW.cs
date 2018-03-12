using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.Contracts
{
    public interface IUoW
    {
        void Commit();
        IGenericInterface<Customer> CustomerRepo { get; set; }
        IGenericInterface<Developer> DeveloperRepo { get; set; }

    }
}
