using GraphQL.Types;

namespace GraphQLTestWebProject.Type
{
    public class InputAddressType : InputObjectGraphType
    {
        public InputAddressType()
        {
            Field<StringGraphType>("houseNumber");
            Field<StringGraphType>("addressLine1");
            Field<StringGraphType>("addressLine2");
            Field<StringGraphType>("city");
            Field<StringGraphType>("country");
            Field<StringGraphType>("postalCode");
        }
    }
}
