namespace TestGraphQLApi.Query
{
    public static class GraphQueries
    {
        public static readonly string usersQuery = @"
            query {
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

        public static readonly string userQuery = @"
            query GetUser($id: Int) {
              user (id: $id){
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
                mutation AddUser($data: InputUserType!) {
                    addUser (user: $data) {
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
                }";

        public static readonly string updateUserQuery = @"
            mutation UpdateUserName($id: Int! $name: String!) {
              updateUser (id: $id, name: $name) {
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
            mutation DeleteUser($id: Int){
              deleteUser(id: $id)
            }
        ";
    }
}
