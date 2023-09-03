﻿
using Newtonsoft.Json;
using TestGraphQLApi.Interfaces;
using TestGraphQLApi.Query;
using TestGraphQLApi.Services;

IUserService service = new UserService();

await GetUsers(service);
await AddUserTest(service);
await UpdateUserTest(service);
await DeleteUserTest(service);

service.Dispose();


static async Task GetUsers(IUserService userService)
{
    var u = await userService.GetUsers();
    Console.WriteLine(JsonConvert.SerializeObject(u, Formatting.Indented));
}
static async Task AddUserTest(IUserService userService)
{
    var userData = @"
        {
            userName: ""Test User 4""
            userEmail: ""test4@gmail.com""
            userPhoneNumber:""1234567890""
            userDateOfBirth: ""1997-03-03""
            address: {
              houseNumber: ""123""
              addressLine1: ""Test Line 1""
              addressLine2: ""Test Line 2""
              city: ""Test City""
              country: ""India""
              postalCode: ""54335""
            }
        }";

    var finalQuery = GraphQueries.addUserQuery.Replace("{{REPLACE_WITH_DATA}}", userData);

    var user = await userService.AddUser(finalQuery);

    Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
}

static async Task UpdateUserTest(IUserService userService)
{
    var userData = @"
        
            id: 9
            name: ""Good Name""
        ";

    var finalQuery = GraphQueries.updateUserQuery.Replace("{{REPLACE_WITH_DATA}}", userData);

    var user = await userService.UpdateUserName(finalQuery);

    Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
}

static async Task DeleteUserTest(IUserService userService)
{
    var userData = @"id: 8";

    var finalQuery = GraphQueries.deleteUserQuery.Replace("{{REPLACE_WITH_DATA}}", userData);

    var user = await userService.DeleteUser(finalQuery);

    Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
}