namespace TestGraphQLApi.Models
{
    public class GraphUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhoneNumber { get; set; } = string.Empty;
        public DateTime UserDateOfBirth { get; set; } = DateTime.Now;
        public GraphAddress Address { get; set; }
    }
}
