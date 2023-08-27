using GraphQL.Types;
using GraphQLTestWebProject.Mutation;
using GraphQLTestWebProject.Query;

namespace GraphQLTestWebProject.Schemas
{
    /// <summary>
    /// Here we are setting the query and mutation in the schema
    /// Extends Schema
    /// </summary>
    /// <seealso cref="GraphQL.Types.Schema" />
    public class UserSchema : Schema
    {
        public UserSchema(UserQuery userQuery, UserMutation userMutation)
        {
            Query = userQuery;
            Mutation = userMutation;
        }
    }
}
