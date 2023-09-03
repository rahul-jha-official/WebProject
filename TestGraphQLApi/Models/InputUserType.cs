namespace TestGraphQLApi.Models
{
    public class InputUserType
    {
        public string userName { get; set; } = string.Empty;
        public string userEmail { get; set; } = string.Empty;
        public string userPhoneNumber { get; set; } = string.Empty;
        public DateTime userDateOfBirth { get; set; } = DateTime.Now;
        public InputAddressType address { get; set; }
    }
}
