using GraphQL.Types;
using GraphQLTestWebProject.Mutation;
using GraphQLTestWebProject.Query;

namespace GraphQLTestWebProject.Schemas
{
    public class UserSchema : Schema
    {
        public UserSchema(UserQuery userQuery, UserMutation userMutation)
        {
            Query = userQuery;
            Mutation = userMutation;
        }
    }
}
