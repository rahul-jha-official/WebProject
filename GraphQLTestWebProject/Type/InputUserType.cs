using GraphQL.Types;

namespace GraphQLTestWebProject.Type
{
    /// <summary>
    /// InputUserType is for taking input as User type. 
    /// </summary>
    /// <seealso cref="GraphQL.Types.InputObjectGraphType" />
    public class InputUserType : InputObjectGraphType
    {
        public InputUserType()
        {
            Field<StringGraphType>("userName");
            Field<StringGraphType>("userEmail");
            Field<StringGraphType>("userPhoneNumber");
            Field<DateGraphType>("userDateOfBirth");
            Field<InputAddressType>("address");
        }
    }
}
