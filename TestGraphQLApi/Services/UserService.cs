using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using TestGraphQLApi.Interfaces;
using TestGraphQLApi.Models;
using TestGraphQLApi.Query;

namespace TestGraphQLApi.Services
{
    public class UserService : IUserService
    {
        private readonly GraphQLHttpClient _graphQLClient;

        public UserService()
        {
            const string url = "http://localhost:5218/graphql";
            var httpClient = new HttpClient();
            var options = new GraphQLHttpClientOptions()
            {
                EndPoint = new Uri(url)
            };
            _graphQLClient = new GraphQLHttpClient(options, new NewtonsoftJsonSerializer(), httpClient);
        }

        public async Task<IEnumerable<GraphUser>> GetUsers()
        {
            try
            {
                var userRequest = new GraphQLRequest()
                {
                    Query = GraphQueries.userQuery
                };
                var graphQLResponse = await _graphQLClient.SendQueryAsync<GraphQLUsersResponse>(userRequest);

                return graphQLResponse.Data.Users;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return new List<GraphUser>();
        }

        public async Task<GraphUser?> AddUser(string query)
        {
            try
            {
                var userRequest = new GraphQLRequest()
                {
                    Query = query
                };
                var graphQLResponse = await _graphQLClient.SendMutationAsync<GraphQLAddUserResponse>(userRequest);

                return graphQLResponse.Data.AddUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public void Dispose()
        {
            _graphQLClient.Dispose();
        }
    }
}
