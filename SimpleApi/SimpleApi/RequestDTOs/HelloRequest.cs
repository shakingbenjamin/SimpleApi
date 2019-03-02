namespace SimpleApi.RequestDTOs
{
    using ServiceStack;

    [Route("/hello")]
    [Route("/hello/{name}")]
    public class HelloRequest
    {
        public string Name { get; set; }
    }
}