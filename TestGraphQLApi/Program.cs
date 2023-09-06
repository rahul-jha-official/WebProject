
using Newtonsoft.Json;
using TestGraphQLApi.Interfaces;
using TestGraphQLApi.Query;
using TestGraphQLApi.Services;

IUserService service = new UserService();

await GetUsers(service);
await GetUser(service);
await AddUserTest(service);
await UpdateUserTest(service);
await DeleteUserTest(service);

service.Dispose();


static async Task GetUsers(IUserService userService)
{
    var users = await userService.QureryOperation(GraphQueries.usersQuery,null);
    Console.WriteLine(JsonConvert.SerializeObject(users, Formatting.Indented));
}

static async Task GetUser(IUserService userService)
{
    var data = GraphVariables.GetDataVariable(id: 3);
    var user = await userService.QureryOperation(GraphQueries.userQuery, data);
    Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
}

static async Task AddUserTest(IUserService userService)
{
    var data = GraphVariables.AddDataVariable(
                            userName: "Test User",
                            userEmail: "test@email.com",
                            "6754685468",
                            "1997-03-03",
                            "123",
                            "XYZ Society",
                            "ABC",
                            "Leaf",
                            "Naruto World",
                            "233431");

    var user = await userService.MutationOperation(GraphQueries.addUserQuery, data);

    Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
}

static async Task UpdateUserTest(IUserService userService)
{
    var data = GraphVariables.UpdateNameDataVariable(id: 13, 
                                                    name: "Naruto Uzamaki");

    dynamic user = await userService.MutationOperation(GraphQueries.updateUserQuery, data);

    Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
}

static async Task DeleteUserTest(IUserService userService)
{
    var data = GraphVariables.DeleteDataVariable(id: 3);

    dynamic flag = await userService.MutationOperation(GraphQueries.deleteUserQuery, data);

    Console.WriteLine(JsonConvert.SerializeObject(flag, Formatting.Indented));
}