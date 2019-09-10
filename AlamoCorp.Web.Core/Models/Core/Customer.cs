using System.ComponentModel.DataAnnotations;

namespace AlamoCorp.Web.Core.Models.Core
{
    public class Customer
    {
        [Key]
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
