namespace SimpleApi.DAL
{
    using SimpleApi.Models;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class SimpleApiInitialiser : DropCreateDatabaseIfModelChanges<SimpleApiContext>
    {
        protected override void Seed(SimpleApiContext context)
        {
            var contacts = new List<Contact>
            {
            new Contact{FirstName="Holly",LastName="Heather", Title="Miss"},
            };

            contacts.ForEach(c => context.Contacts.Add(c));
            context.SaveChanges();
        }
    }
}