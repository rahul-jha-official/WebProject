using GraphQL;
using GraphQL.Types;
using GraphQLTestWebProject.Interfaces;
using GraphQLTestWebProject.Type;

namespace GraphQLTestWebProject.Query
{
    public class UserQuery : ObjectGraphType
    {
        public UserQuery(IUserService userService)
        {
            Field<ListGraphType<UserType>>("users", 
                                            resolve: ctx => userService.GetUsers());
            Field<UserType>("user", 
                arguments: new QueryArguments(new QueryArgument<IntGraphType>
                {
                    Name = "id",
                }),
                resolve: ctx => userService.GetUserById(ctx.GetArgument<int>("id")));
        }
    }
}
