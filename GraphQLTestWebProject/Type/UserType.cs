using GraphQL.Types;
using GraphQLTestWebProject.Models;

namespace GraphQLTestWebProject.Type
{
    /// <summary>
    /// GraphQL cannot use existing model, we define type for GraphQL.
    /// UserType is the GraphQL datatype which extends ObjectGraphType
    /// </summary>
    /// <seealso cref="GraphQL.Types.ObjectGraphType&lt;GraphQLTestWebProject.Models.User&gt;" />
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(u => u.UserId);
            Field(u => u.UserName);
            Field(u => u.UserEmail);
            Field(u => u.UserPhoneNumber);
            Field(u => u.UserDateOfBirth);
            Field<AddressType>("address", resolve: ctx => ctx.Source.Address);
        }
    }
}
