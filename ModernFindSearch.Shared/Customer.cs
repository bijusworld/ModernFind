using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernFindSearch.Shared
{
    public class Customer
    {
        [Required]
        public int CustomerId { get; set; }
        public CustomerCategory CustomerCategory { get; set; }
        public string CustomerName { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
    }
}
