namespace SimpleApi.Services
{
    using ServiceStack;
    using SimpleApi.DAL;
    using SimpleApi.Models;
    using SimpleApi.RequestDTOs;
    using SimpleApi.ResponseDTOs;
    using System.Collections.Generic;
    using System.Linq;

    public class ContactService : Service
    {
        private readonly SimpleApiContext context = new SimpleApiContext();

        public GetContactResponse GetContact(GetContactRequest request)
        {
            var contact = new Contact();
            contact = context.Contacts.FirstOrDefault(c => c.LastName.ToLower() == request.LastName.ToLower());
            return new GetContactResponse { Result = contact };
        }

        public List<Contact> GetContacts()
        {
            var contacts = new List<Contact> { new Contact() };
            return contacts;
        }
    }
}