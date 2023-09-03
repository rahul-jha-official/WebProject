using TestGraphQLApi.Models;

namespace TestGraphQLApi.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<IEnumerable<GraphUser>> GetUsers();
        Task<GraphUser?> AddUser(string query);
        Task<GraphUser?> UpdateUserName(string query);
        Task<bool> DeleteUser(string query);
    }
}
