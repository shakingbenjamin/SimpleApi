namespace SimpleApi.Interfaces
{
    using SimpleApi.Models;
    using SimpleApi.RequestDTOs;
    using SimpleApi.ResponseDTOs;
    using System.Collections.Generic;

    public interface IContactService
    {
        GetContactResponse Get(GetContactRequest request);

        List<Contact> GetContacts();
    }
}
