using Centisoft.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.DAL
{
    public class GenericRepo<T> : IGenericInterface<T> where T : class
    {
        private CentisoftContext context;
        private IDbSet<T> dbset;
        public GenericRepo()
        {
            context = new CentisoftContext();
            dbset = context.Set<T>();
        }
        public void Save(T t)
        {
            var entry = this.context.Entry(t);
            if (entry.State != System.Data.Entity.EntityState.Detached)
            {
                this.dbset.Attach(t);
                entry.State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                this.dbset.Add(t);
            }
            this.context.SaveChanges();
        }

        public void Delete(T t)
        {
            this.dbset.Remove(t);
            this.context.SaveChanges();
        }

        public T Get(int id)
        {
            return this.dbset.Find(id);
        }

        public List<T> GetAll()
        {
            return this.dbset.ToList();
        }
    }
}
