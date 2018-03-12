using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.DAL
{
    public class BaseRepo
    {
        protected CentisoftContext context;

        public BaseRepo()
        {
            context = new CentisoftContext();
        }
    }
}
