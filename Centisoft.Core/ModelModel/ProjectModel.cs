using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.ModelModel
{
    public class ProjectModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public int MyProperty { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
