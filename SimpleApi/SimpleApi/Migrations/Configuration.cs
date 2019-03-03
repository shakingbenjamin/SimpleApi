namespace SimpleApi.Migrations
{
    using SimpleApi.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleApi.DAL.SimpleApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SimpleApi.DAL.SimpleApiContext";
        }

        protected override void Seed(SimpleApi.DAL.SimpleApiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Addresses.AddOrUpdate(x => x.ID,
                new Address { NameOrNumber = "Flat 50", Street = "Kings Court", City = "Guildford", Province = "Surrey", PostCode = "GU23 4DT"});
           
            context.Contacts.AddOrUpdate(x => x.ID,
                new Contact { FirstName="Jane", LastName="Doe", Title="Miss", Mobile = "07525175792", AddressID = 1 },
                new Contact { FirstName="Davie", LastName="Jones", Title="Mr", Mobile = "0758634695" }
            );
        }
    }
}
