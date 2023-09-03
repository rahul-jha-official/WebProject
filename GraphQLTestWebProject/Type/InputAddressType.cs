using GraphQL.Types;

namespace GraphQLTestWebProject.Type
{
    public class InputAddressType : InputObjectGraphType
    {
        public InputAddressType()
        {
            Field<StringGraphType>("HouseNumber");
            Field<StringGraphType>("AddressLine1");
            Field<StringGraphType>("AddressLine2");
            Field<StringGraphType>("City");
            Field<StringGraphType>("Country");
            Field<StringGraphType>("PostalCode");
        }
    }
}
