namespace Centisoft.Core.Migrations
{
    using Centisoft.Core.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Centisoft.Core.DAL.CentisoftContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Centisoft.Core.DAL.CentisoftContext context)
        {
            //  This method will be called after migrating to the latest version.          
                //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
