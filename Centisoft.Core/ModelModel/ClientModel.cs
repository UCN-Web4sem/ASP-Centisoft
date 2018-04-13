using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.ModelModel
{
    public class ClientModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public List<CustomerModel> Customers { get; set; }
    }
}
