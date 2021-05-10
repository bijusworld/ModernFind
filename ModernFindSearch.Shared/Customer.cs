using System.ComponentModel.DataAnnotations;

namespace ModernFindSearch.Shared
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public CustomerCategory CustomerCategory { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Customer name is too long.")]
        public string CustomerName { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
    }
}
