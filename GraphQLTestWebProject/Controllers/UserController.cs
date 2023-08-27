using GraphQLTestWebProject.Interfaces;
using GraphQLTestWebProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLTestWebProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/users")]
        public IEnumerable<User> Get()
        {
            return _userService.GetUsers();
        }

        [HttpGet("/user/{id}")]
        public User? Get(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost("/user")]
        public User Create([FromBody] User user)
        {
            return _userService.AddUser(user);
        }

        [HttpPut("/user")]
        public User Update(int id, string name)
        {
            return _userService.UpdateUserName(id, name);
        }

        [HttpDelete("/user")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}
