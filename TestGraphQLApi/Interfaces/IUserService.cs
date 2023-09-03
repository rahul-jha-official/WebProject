using TestGraphQLApi.Models;

namespace TestGraphQLApi.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<IEnumerable<GraphUser>> GetUsers();
        Task<GraphUser?> AddUser(string variable);
    }
}
