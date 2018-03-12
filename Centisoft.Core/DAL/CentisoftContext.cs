using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.DAL
{
    public class CentisoftContext : DbContext
    {
        public CentisoftContext() : base("centisoftConnectionstring") { }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
