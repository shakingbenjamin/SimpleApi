namespace SimpleApi.Interfaces
{
    using SimpleApi.RequestDTOs;

    public interface IHelloService
    {
        object Any(HelloRequest request);
    }
}
