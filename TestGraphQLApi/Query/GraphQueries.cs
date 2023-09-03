namespace TestGraphQLApi.Query
{
    public static class GraphQueries
    {
        public static readonly string userQuery = @"
            {
              users {
                userId
                userName
                userEmail
                userPhoneNumber
                userDateOfBirth
                address {
                  addressId
                  houseNumber
                  addressLine1
                  addressLine2
                  city
                  country
                  postalCode
                }
              }
            }    
        ";

        public static readonly string addUserQuery = @"
            mutation {
              addUser (user: {{REPLACE_WITH_DATA}}) {
                userId
                userName
                userEmail
                userPhoneNumber
                userDateOfBirth
                address {
                  addressId
                  houseNumber
                  addressLine1
                  addressLine2
                  city
                  country
                  postalCode
                }
              }
            }
        ";

        public static readonly string updateUserQuery = @"
            mutation {
              updateUser ({{REPLACE_WITH_DATA}}) {
                userId
                userName
                userEmail
                userPhoneNumber
                userDateOfBirth
                address {
                  addressId
                  houseNumber
                  addressLine1
                  addressLine2
                  city
                  country
                  postalCode
                }
              }
            }
        ";

        public static readonly string deleteUserQuery = @"
            mutation {
              deleteUser({{REPLACE_WITH_DATA}})
            }
        ";
    }
}
