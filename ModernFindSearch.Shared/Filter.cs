using System.ComponentModel.DataAnnotations;

namespace ModernFindSearch.Shared
{
    public class ProductFilter : Filter
    {
        public string ProductReference { get; set; }

        public bool Reload { get; set; } = false;
    }

    public class Filter
    {
        public int? Skip { get; set; } = 0;

        [Required]
        public int? Take { get; set; } = 10;
    }
}