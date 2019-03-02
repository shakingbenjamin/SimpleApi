namespace SimpleApi.Services
{
    using ServiceStack;
    using SimpleApi.RequestDTOs;
    using SimpleApi.ResponseDTOs;

    public class HelloService : Service
    {
        public object Any(HelloRequest request)
        {
            return new HelloResponse { Result = $"Hello {request.Name}" };
        }
    }
}