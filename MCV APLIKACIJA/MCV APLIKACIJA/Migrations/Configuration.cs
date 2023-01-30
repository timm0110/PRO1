namespace MCV_APLIKACIJA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MCV_APLIKACIJA.Data.MCV_APLIKACIJAContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MCV_APLIKACIJA.Data.MCV_APLIKACIJAContext";
        }

        protected override void Seed(MCV_APLIKACIJA.Data.MCV_APLIKACIJAContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
