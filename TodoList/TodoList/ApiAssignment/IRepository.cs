
namespace planets
{
    public interface IRepository
    {
        Task<string> Read(string baseAddress, string requestUri);
    }
}

