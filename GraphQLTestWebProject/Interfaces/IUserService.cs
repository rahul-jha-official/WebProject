using GraphQLTestWebProject.Models;

namespace GraphQLTestWebProject.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User? GetUserById(int id);
        User? AddUser(User user);
        User? UpdateUserName(int id, string name);
        bool DeleteUser(int id);
    }
}
