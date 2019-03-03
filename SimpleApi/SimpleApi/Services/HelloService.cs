namespace SimpleApi.Services
{
    using ServiceStack;
    using SimpleApi.RequestDTOs;
    using SimpleApi.ResponseDTOs;

    public class HelloService : Service
    {
        public object Any(HelloRequest request)
        {
            var message = string.Empty;
            if (request.Name.ToLower() == "holly")
            {
                message = "Hi Holly, know you love this 'dork shit.";
            }
            else
            {
                message = $"Hello {request.Name}";
            }
            
            return new HelloResponse { Result = message };
        }
    }
}