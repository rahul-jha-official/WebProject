using GraphQL.Types;
using GraphQLTestWebProject.Models;

namespace GraphQLTestWebProject.Type
{
    public class AddressType : ObjectGraphType<Address>
    {
        public AddressType()
        {
            Field(a => a.AddressId);
            Field(a => a.HouseNumber);
            Field(a => a.AddressLine1);
            Field(a => a.AddressLine2);
            Field(a => a.City);
            Field(a => a.Country);
            Field(a => a.PostalCode);
        }
    }
}
