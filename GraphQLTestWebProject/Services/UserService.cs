using GraphQLTestWebProject.Interfaces;
using GraphQLTestWebProject.Models;

namespace GraphQLTestWebProject.Services
{
    public class UserService : IUserService
    {
        private static List<User> users = new List<User>()
        {
            new User()
            {
                UserId = 1,
                UserName = "Test",
                UserEmail = "test@email.com",
                UserPhoneNumber = "1234567890",
                UserDateOfBirth = DateTime.Now,
                UserAddress = new Address()
                {
                    HouseNumber = "221B",
                    AddressLine1 = "Baker Street",
                    AddressLine2 = string.Empty,
                    City = "London",
                    Country = "United Kingdom",
                    PostalCode = "12345",
                }
            },
        };

        public User AddUser(User user)
        {
            if (user is null || users.Any(u => u.UserId == user.UserId))
            {
                throw new Exception("Cannot Add User");
            }
            users.Add(user);
            return user;
        }

        public void DeleteUser(int id)
        {
            User u = users.FirstOrDefault(u => u.UserId == id);
            if (u is null)
            {
                throw new Exception("Cannot Delete User");
            }
            users.Remove(u);
        }

        public User? GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.UserId == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public User UpdateUserName(int id, string name)
        {
            User u = users.FirstOrDefault(u => u.UserId == id);
            if (u is null)
            {
                throw new Exception("Cannot Update UserName");
            }
            u.UserName = name;

            return u;
        }
    }
}
