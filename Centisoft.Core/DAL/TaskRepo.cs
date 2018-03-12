using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.DAL
{
    public class TaskRepo : BaseRepo
    {
        public List<Models.Task> LoadAll()
        {
            return context.Tasks.ToList();
        }

        public Models.Task Load(int id)
        {
            return context.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Models.Task ta)
        {
            if (ta.Id > 0)
            {
                context.Entry(ta).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                context.Tasks.Add(ta);
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Models.Task task = Load(id);
            context.Tasks.Remove(task);
        }
    }
}
