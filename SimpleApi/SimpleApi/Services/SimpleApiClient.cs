namespace SimpleApi.Services
{
    using SimpleApi.Interfaces;

    public class SimpleApiClient : ISimpleApiClient
    {
        public IHelloService HelloService
        {
            get { return new HelloService(); }
        }

        public IContactService ContactService
        {
            get { return new ContactService(); }
        }
    }
}