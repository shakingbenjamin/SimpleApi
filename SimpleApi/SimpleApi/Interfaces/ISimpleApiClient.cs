namespace SimpleApi.Interfaces
{
    public interface ISimpleApiClient
    {
        IHelloService HelloService { get; }

        IContactService ContactService { get; }
    }
}
