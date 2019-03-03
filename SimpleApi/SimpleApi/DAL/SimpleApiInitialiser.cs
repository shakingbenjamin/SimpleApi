namespace SimpleApi.DAL
{
    using SimpleApi.Models;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class SimpleApiInitialiser : DropCreateDatabaseIfModelChanges<SimpleApiContext>
    {
        protected override void Seed(SimpleApiContext context)
        {
            var addresses = new List<Address>
            {
                new Address { NameOrNumber = "", Street = "", City = "", Province = "", PostCode = ""}
            };

            addresses.ForEach(a => context.Addresses.Add(a));
            context.SaveChanges();

            var contacts = new List<Contact>
            {
                new Contact { FirstName="Jane", LastName="Doe", Title="Miss"},
                new Contact { FirstName="Davie", LastName="Jones", Title="Mr" }
            };


            contacts.ForEach(c => context.Contacts.Add(c));
            context.SaveChanges();
        }
    }
}