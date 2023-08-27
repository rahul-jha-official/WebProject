using GraphQL.Types;

namespace GraphQLTestWebProject.Type
{
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
