﻿namespace SimpleApi.Services
{
    using ServiceStack;
    using SimpleApi.DAL;
    using SimpleApi.Interfaces;
    using SimpleApi.Models;
    using SimpleApi.RequestDTOs;
    using SimpleApi.ResponseDTOs;
    using System.Collections.Generic;
    using System.Linq;
    using ServiceStack.OrmLite;

    public class ContactService : Service, IContactService
    {
        //private readonly SimpleApiContext context = new SimpleApiContext();

        public GetContactResponse Get(GetContactRequest request)
        {
            var contact = new Contact();
            contact = this.Db.Single<Contact>(c => c.LastName.ToLower() == request.LastName.ToLower());
            contact.Address = this.Db.Single<Address>(a => a.ID == contact.ID);
            //contact = context.Contacts.FirstOrDefault(c => c.LastName.ToLower() == request.LastName.ToLower());
            //contact.Address = context.Addresses.FirstOrDefault(a => a.ID == contact.ID);
            return new GetContactResponse { Result = contact };
        }

        public List<Contact> GetContacts()
        {
            var contacts = new List<Contact> { new Contact() };
            return contacts;
        }
    }
}