namespace JBPart5INFO2200.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JBPart5INFO2200.ProductEntityDb>
    {
        public Configuration()
        {
            // manually changed to true
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(JBPart5INFO2200.ProductEntityDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
