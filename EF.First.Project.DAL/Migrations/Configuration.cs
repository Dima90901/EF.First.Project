namespace EF.First.Project.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF.First.Project.DAL.Contex.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EF.First.Project.DAL.Contex.Model1";
        }

        protected override void Seed(EF.First.Project.DAL.Contex.Model1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
