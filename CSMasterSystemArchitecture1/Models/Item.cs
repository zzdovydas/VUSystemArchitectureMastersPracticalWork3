using System.ComponentModel.DataAnnotations;

namespace CSMasterSystemArchitecture1.Models
{
    public class Item
    {
        [Key]
        public string? Guid { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string? CountryOfOrigin { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
