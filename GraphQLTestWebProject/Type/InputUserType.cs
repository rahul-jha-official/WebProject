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
            Field<IntGraphType>("userId");
            Field<StringGraphType>("userName");
            Field<StringGraphType>("userEmail");
            Field<StringGraphType>("UserPhoneNumber");
            Field<DateGraphType>("UserDateOfBirth");
        }
    }
}
