using System.ComponentModel.DataAnnotations;

namespace Rasai_web.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
    }
}
