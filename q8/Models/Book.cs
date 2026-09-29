using System.ComponentModel.DataAnnotations;

namespace q8.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = "";

        [Required]
        public string Author { get; set; } = "";

        [Required]
        public string Category { get; set; } = "";

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}