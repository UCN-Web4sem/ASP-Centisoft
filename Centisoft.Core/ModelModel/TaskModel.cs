using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.ModelModel
{
    public class TaskModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public float Duration { get; set; }
        public ProjectModel Project { get; set; }
        public DeveloperModel Developer { get; set; }
    }
}
