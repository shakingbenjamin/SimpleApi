namespace SimpleApi.RequestDTOs
{
    using ServiceStack;
    [Route("/GetContact/{lastName}")]
    public class GetContactRequest
    {
         public string LastName { get; set; }
    }
}