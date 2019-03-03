namespace SimpleApi.RequestDTOs
{
    using ServiceStack;
    [Route("/GetContacts/{lastName}")]
    public class GetContactRequest
    {
        public GetContactRequest(string lastName)
        {
            this.LastName = LastName;
        }

        public string LastName { get; set; }
    }
}