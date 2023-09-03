using GraphQLTestWebProject.Data;
using GraphQLTestWebProject.Interfaces;
using GraphQLTestWebProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLTestWebProject.Services
{
    public class UserService : IUserService
    {
        private readonly GraphQLDbContext _graphQLDbContext;

        public UserService(GraphQLDbContext graphQLDbContext)
        {
            _graphQLDbContext = graphQLDbContext;
        }

        public User? AddUser(User user)
        {
            _graphQLDbContext.Users.Add(user);
            var rowsAffected = _graphQLDbContext.SaveChanges();

            if (rowsAffected == 1)
            {
                return user;
            }
            return null;
        }

        public bool DeleteUser(int id)
        {
            var user = _graphQLDbContext.Users.Include(u => u.Address).SingleOrDefault(u => u.UserId == id);

            if (user is null) return false;
            _graphQLDbContext.Users.Remove(user);
            var rowsAffected = _graphQLDbContext.SaveChanges();
            return rowsAffected == 1;
        }

        public User? GetUserById(int id)
        {
            return _graphQLDbContext.Users.Find(id);
        }

        public IEnumerable<User> GetUsers()
        {
            var allUsers = _graphQLDbContext.Users.Include(user => user.Address).ToList();
            return allUsers;
        }

        public User? UpdateUserName(int id, string name)
        {
            var user = _graphQLDbContext.Users.Find(id);
            if (user is null)
            {
                return null;
            }
            user.UserName = name;
            _graphQLDbContext.SaveChanges();
            return user;
        }
    }
}
