using TestGraphQLApi.Models;

namespace TestGraphQLApi.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<dynamic> QureryOperation(string query, object variable);
        Task<dynamic> MutationOperation(string query, object variable);
    }
}
