namespace TestGraphQLApi.Models
{
    public class InputAddressType
    {
        public string houseNumber { get; set; } = string.Empty;

        public string addressLine1 { get; set; } = string.Empty;

        public string addressLine2 { get; set; } = string.Empty;

        public string city { get; set; } = string.Empty;

        public string postalCode { get; set; } = string.Empty;

        public string country { get; set; } = string.Empty;
    }
}
