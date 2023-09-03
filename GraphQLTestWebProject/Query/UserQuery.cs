using GraphQL;
using GraphQL.Types;
using GraphQLTestWebProject.Interfaces;
using GraphQLTestWebProject.Type;

namespace GraphQLTestWebProject.Query
{
    /// <summary>
    /// Here we are defining the queries.
    /// Also extends ObjectGraphType
    /// </summary>
    /// <seealso cref="GraphQL.Types.ObjectGraphType" />
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
