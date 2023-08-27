namespace GraphQLTestWebProject.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhoneNumber { get; set; } = string.Empty;
        public Address UserAddress { get; set; }
        public DateTime UserDateOfBirth { get; set; } = DateTime.Now;
    }
}
