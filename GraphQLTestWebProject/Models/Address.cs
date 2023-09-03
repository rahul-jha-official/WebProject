using System.ComponentModel.DataAnnotations;

namespace GraphQLTestWebProject.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string HouseNumber { get; set; } = string.Empty;

        public string AddressLine1 { get; set; } = string.Empty;

        public string AddressLine2 { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

    }
}
