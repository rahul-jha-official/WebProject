using GraphQL;
using GraphQL.Types;
using GraphQLTestWebProject.Interfaces;
using GraphQLTestWebProject.Models;
using GraphQLTestWebProject.Type;

namespace GraphQLTestWebProject.Mutation
{
    /// <summary>
    /// Here we are setting the query for CREATE, UPDATE and DELETE Operation.
    /// </summary>
    /// <seealso cref="GraphQL.Types.ObjectGraphType" />
    public class UserMutation : ObjectGraphType
    {
        public UserMutation(IUserService userService)
        {
            Field<UserType>("addUser",
                arguments: new QueryArguments(new QueryArgument<InputUserType>
                {
                    Name = "user",
                }),
                resolve: ctx => userService.AddUser(ctx.GetArgument<User>("user")));

            Field<UserType>("updateUser",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType>
                    {
                        Name = "id",
                    },
                    new QueryArgument<StringGraphType>
                    {
                        Name = "name",
                    }
                    ),
                resolve: ctx => userService.UpdateUserName(ctx.GetArgument<int>("id"), ctx.GetArgument<string>("name")));


            Field<BooleanGraphType>("deleteUser",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>
                {
                    Name = "id",
                }),
                resolve: ctx =>
                {
                    userService.DeleteUser(ctx.GetArgument<int>("id"));
                    return true;
                });
        }
    }
}
