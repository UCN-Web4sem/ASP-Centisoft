using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.DAL
{
    public class ProjectRepo : BaseRepo
    {
        public List<Project> LoadAll()
        {
            return context.Projects.ToList();
        }

        public Project Load(int id)
        {
            return context.Projects.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Project pro)
        {
            if (pro.Id > 0)
            {
                context.Entry(pro).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                context.Projects.Add(pro);
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Project pro = Load(id);
            context.Projects.Remove(pro);
        }
    }
}
