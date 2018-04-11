namespace MVCTutorial5.Migrations
{
    using MVCTutorial5.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCTutorial5.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCTutorial5.Models.ApplicationDbContext context)
        {

            context.Products.AddOrUpdate(p => p.ProductID,
              new Product
              {
                  ProductID = 1,
                  Description = "TV",
                  Brand = "Samsung",
                  Quantity = 1,
                  Price = 500,

              },
              new Product
              {
                  ProductID = 2,
                  Description = "M�vil",
                  Brand = "Apple",
                  Quantity = 1,
                  Price = 600,

              }
           );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
