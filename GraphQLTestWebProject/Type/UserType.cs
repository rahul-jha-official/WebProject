using GraphQL.Types;
using GraphQLTestWebProject.Models;

namespace GraphQLTestWebProject.Type
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType() 
        {
            Field(u => u.UserId);
            Field(u => u.UserName);
            Field(u => u.UserEmail);
            Field(u => u.UserPhoneNumber);
            Field(u => u.UserDateOfBirth);
        }
    }
}
